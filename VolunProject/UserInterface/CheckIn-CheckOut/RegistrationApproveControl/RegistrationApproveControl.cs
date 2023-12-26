using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.UserInterface.Event.UserRegisterInformation;
using static VolunProject.OtherFunction;

namespace VolunProject.UserInterface.CheckIn_CheckOut.RegistrationApproveControl
{
    public partial class RegistrationApproveControl : UserControl
    {
        private RegistrationVolunteerDTO RegistrationVolunteerDTOss;
        public static event EventHandler ResetDataEvent;
        public RegistrationApproveControl(RegistrationVolunteerDTO registrationVolunteerDTO)
        {
            InitializeComponent();
            LoadData(registrationVolunteerDTO);
        }
        private void LoadData(RegistrationVolunteerDTO registrationVolunteerDTO)
        {
            RegistrationVolunteerDTOss = registrationVolunteerDTO;
            Image image;
            using (MemoryStream ms = new MemoryStream(registrationVolunteerDTO.VolunteerImg))
            {
                image = Image.FromStream(ms);
                USImg.Image = image;
            }
            if (registrationVolunteerDTO.CheckIn == true && registrationVolunteerDTO.CheckOut == true)
            {
                CheckInBTN.Enabled = false;
                CheckOutBTN.Enabled = false;
                statusLB.Text = "Hoàn Thành";
                statusPanel.BackColor = Color.LightGreen;
            }
            else if (registrationVolunteerDTO.CheckIn == true)
            {
                CheckInBTN.Enabled = false;
                statusLB.Text = "Đã Check-In";
                statusPanel.BackColor = Color.Orange;
            }
            else
            {
                CheckOutBTN.Enabled = false;
                statusLB.Text = "Chưa điểm danh";
                statusPanel.BackColor = Color.Gray;
            }
            addressLB.Text = $"{registrationVolunteerDTO.AddressDetail}, {registrationVolunteerDTO.wardName}, {registrationVolunteerDTO.districtName}, {registrationVolunteerDTO.cityName}";
            GenderLB.Text = registrationVolunteerDTO.Gender ? "Nam" : "Nữ";
            PhoneLB.Text = registrationVolunteerDTO.PhoneNumber;
            EmailLB.Text = registrationVolunteerDTO.Email;

            CheckInDate.Text = registrationVolunteerDTO.CheckInDate.ToString();
            CheckOutDate.Text = registrationVolunteerDTO.CheckOutDate.ToString();

            VolunteerName.Text = registrationVolunteerDTO.Name;
        }

        private void SearchVolunteerBTN_Click(object sender, EventArgs e)
        {
            UserRegisterInformation userRegisterInformation = new UserRegisterInformation(RegistrationVolunteerDTOss.VolunteerID);
            userRegisterInformation.Show();
        }

        private void CheckInBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận Check-In ứng viên này ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (EventBLL.Event_ParticipateChecking(RegistrationVolunteerDTOss.EventID, RegistrationVolunteerDTOss.VolunteerID, "I"))
                {
                    DialogResult re =  MessageBox.Show("Check-In thành công", "Thông báo", MessageBoxButtons.OK);
                    if (re == DialogResult.OK)
                    {
                        var eventq = EventBLL.Event_ById(RegistrationVolunteerDTOss.EventID);
                        NotificationDTO notificationDTO = new NotificationDTO();
                        notificationDTO.NotificationContent = $"Bạn vừa được check-in  tại sự kiện  {EventBLL.Event_ById(eventq.EventID).EventName} vào lúc {DateTime.Now}.";
                        notificationDTO.AccountID = RegistrationVolunteerDTOss.AccountID;
                        notificationDTO.NotiImg = eventq.EventImage;
                        if (NotificationBLL.Notification_Add(notificationDTO))
                        {
                            ResetDataEvent(this, new EventArgs());
                        }
                    }
                }
            }
        }

        private void CheckOutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận Check-Out ứng viên này ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (EventBLL.Event_ParticipateChecking(RegistrationVolunteerDTOss.EventID, RegistrationVolunteerDTOss.VolunteerID, "O"))
                {
                    DialogResult re = MessageBox.Show("Check-Out thành công", "Thông báo", MessageBoxButtons.OK);
                    if (re == DialogResult.OK)
                    {
                        var eventq = EventBLL.Event_ById(RegistrationVolunteerDTOss.EventID);
                        NotificationDTO notificationDTO = new NotificationDTO();
                        notificationDTO.NotificationContent = $"Bạn vừa được check-out tại sự kiện {EventBLL.Event_ById(eventq.EventID).EventName} vào lúc {DateTime.Now}.";
                        notificationDTO.AccountID = RegistrationVolunteerDTOss.AccountID;
                        notificationDTO.NotiImg = eventq.EventImage;
                        if (NotificationBLL.Notification_Add(notificationDTO))
                        {
                            ResetDataEvent(this, new EventArgs());
                        }
                    }
                    if (VolunteerBLL.updatePoint(RegistrationVolunteerDTOss.VolunteerID))
                    {

                    }
                }
            }
        }
    }
}
