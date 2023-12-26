using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.EventRegistrationForm
{
    public partial class RegistrationForm : Form
    {
        private EventDTO eventDTO1;
        public static event EventHandler LoadAlllEvent;
        public RegistrationForm(EventDTO eventDTO)
        {
            InitializeComponent();
            LoadForm(eventDTO);
        }
        private void LoadForm(EventDTO eventDTO)
        {
            eventDTO1 = eventDTO;
            EventNameLB.Text = eventDTO.EventName;
            OrganizationLB.Text = OrganizationBLL.getOrganizationByID(eventDTO.OrganizationID).OrganizationName;
            AddressLB.Text = $"{eventDTO.DetailAddress}, {eventDTO.wardName}, {eventDTO.districtName}, {eventDTO.cityName}";
            DatetimeLB.Text = $"{eventDTO.StartDate?.ToString("dd/MM/yyyy")} - {eventDTO.EndDate?.ToString("dd/MM/yyyy")} - {eventDTO.time}";
            /*if ()
            {

            }*/
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            if (curVol.status == true)
            {
                if (EventBLL.Event_Register(eventDTO1.EventID, curVol.VolunteerID))
                {
                    DialogResult result = MessageBox.Show("Đăng ký tham gia thành công, hãy đợi đơn vị tổ chức duyệt", "Thông báo", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        // var eventq = EventBLL.Event_ById(RegistrationVolunteerDTOss.EventID);
                        NotificationDTO notificationDTO = new NotificationDTO();
                        notificationDTO.NotificationContent = $"Bạn vừa đăng ký tham gia sự kiện {eventDTO1.EventName} vào lúc {DateTime.Now}.";
                        notificationDTO.AccountID = curUser.AccountID;
                        notificationDTO.NotiImg = eventDTO1.EventImage;
                        var result2 = NotificationBLL.Notification_Add(notificationDTO);
                        if (result2)
                        {
                            LoadAlllEvent(this, new EventArgs());
                            if (result2)
                            {
                                this.Close();
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng cập nhật đầy đủ thông tin trước khi đăng ký tham gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
