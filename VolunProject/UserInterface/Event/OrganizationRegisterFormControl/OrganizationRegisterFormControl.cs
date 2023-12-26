using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.OrganizationRegisterFormControl
{
    public partial class OrganizationRegisterFormControl : UserControl
    {
        private RegisterVolunteerFormDTO registerVolunteerFormDTO1;
        public static event EventHandler LoadEvent;
        public OrganizationRegisterFormControl(RegisterVolunteerFormDTO registerVolunteerFormDTO)
        {
            InitializeComponent();
            LoadControll(registerVolunteerFormDTO);
            SearchEvent.Visible = false;
            SearchEvent.Enabled = false;
        }
        private void LoadControll(RegisterVolunteerFormDTO registerVolunteerFormDTO)
        {

        

            registerVolunteerFormDTO1 = registerVolunteerFormDTO;
            Image image;
            using (MemoryStream ms = new MemoryStream(registerVolunteerFormDTO.VolunteerImage))
            {
                image = Image.FromStream(ms);
                UserImageBox.Image = image;
            }
            switch (registerVolunteerFormDTO.Status)
            {
                case "A": statusLB.Text = "Đã duyệt"; this.statusPanel.BackColor = System.Drawing.Color.LimeGreen; ApproveBTN.Enabled = false; CancelBTN.Enabled = false;  break;
                case "C": statusLB.Text = "Chờ duyệt"; this.statusPanel.BackColor = System.Drawing.Color.DarkGray; break;
                case "R": statusLB.Text = "Từ chối"; this.statusPanel.BackColor = System.Drawing.Color.IndianRed; ApproveBTN.Enabled = false; CancelBTN.Enabled = false; break;
            }
            VolunteerName.Text = registerVolunteerFormDTO.VolunteerName;
            EventName.Text = registerVolunteerFormDTO.EventName;
            addressLB.Text = $"{registerVolunteerFormDTO.DetailAddress}, {registerVolunteerFormDTO.wardName}, {registerVolunteerFormDTO.districtName}, {registerVolunteerFormDTO.cityName}";
            TimeLB.Text = registerVolunteerFormDTO.time;
            DateTimeLB.Text = $"{registerVolunteerFormDTO.StartDate.ToString("dd/MM/yyyy")} - {registerVolunteerFormDTO.EndDate.ToString("dd/MM/yyyy")}";
            RegisterDate.Text = registerVolunteerFormDTO.registerDate.ToString();
        }
        private void addressLB_Click(object sender, EventArgs e)
        {

        }

        private void ApproveBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận duyệt ứng viên này ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
               
                if (EventBLL.Event_Approve(registerVolunteerFormDTO1.EventID, registerVolunteerFormDTO1.VolunteerID))
                {
                    
                    DialogResult result1 = MessageBox.Show("Duyệt ứng viên thành công", "Thông báo", MessageBoxButtons.OK);
                    if (result1 == DialogResult.OK)
                    {

                        // them thông báo vào bên đơn vị
                        var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser"); 
                        NotificationDTO notificationDTO = new NotificationDTO();
                        notificationDTO.NotificationContent = $"Ứng viên {registerVolunteerFormDTO1.VolunteerName} được duyệt tham gia sự kiện {registerVolunteerFormDTO1.EventName} vào lúc {DateTime.Now}.";
                        notificationDTO.AccountID = curUser.AccountID;
                        notificationDTO.NotiImg = registerVolunteerFormDTO1.VolunteerImage;

                        NotificationDTO notificationDTO2 = new NotificationDTO();
                        notificationDTO2.NotificationContent = $"Bạn vừa được duyệt tham gia sự kiện {registerVolunteerFormDTO1.EventName} vào lúc {DateTime.Now}.";
                        notificationDTO2.AccountID = VolunteerBLL.GetVolunteerByVolunteerID(registerVolunteerFormDTO1.VolunteerID).AccountID;
                        notificationDTO2.NotiImg = registerVolunteerFormDTO1.VolunteerImage;
                        // them thông báo vào bên người dùng

                        if (NotificationBLL.Notification_Add(notificationDTO) && NotificationBLL.Notification_Add(notificationDTO2))
                        {
                            LoadEvent(this, new EventArgs());
                        }
                       
                    }
                };
            }

        }

        private void DetailVolunteerBTN_Click(object sender, EventArgs e)
        {
               UserRegisterInformation.UserRegisterInformation  userRegisterInformation =  new UserRegisterInformation.UserRegisterInformation(registerVolunteerFormDTO1.VolunteerID);
               userRegisterInformation.Show();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận từ chối duyệt ứng viên này ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                if (EventBLL.Event_Reject(registerVolunteerFormDTO1.EventID, registerVolunteerFormDTO1.VolunteerID))
                {
                    var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                    NotificationDTO notificationDTO = new NotificationDTO();
                    notificationDTO.NotificationContent = $"Ứng viên {registerVolunteerFormDTO1.VolunteerName} đã bị từ chối duyệt tham gia sự kiện {registerVolunteerFormDTO1.EventName} vào lúc {DateTime.Now}.";
                    notificationDTO.AccountID = curUser.AccountID;
                    notificationDTO.NotiImg = registerVolunteerFormDTO1.VolunteerImage;
                    if (NotificationBLL.Notification_Add(notificationDTO))
                    {
                        LoadEvent(this, new EventArgs());
                    }
                };
            }
        }

        private void SearchEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
