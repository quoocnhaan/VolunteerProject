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

namespace VolunProject.UserInterface.EventDetail
{
    
    public partial class EventDetail_UC : UserControl
    {
        public static event EventHandler BackToEvents;
        public static event EventHandler BackToEventsMain;

        private EventDTO eventModel;
        public EventDetail_UC(EventDTO eventDTO)
        {
            InitializeComponent();
            LoadDetailEvent(eventDTO);

        }
        private void LoadDetailEvent(EventDTO eventDTO)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            eventModel = eventDTO;
            Like.Text = eventDTO.LikeCount.ToString();
            EventName.Text = eventDTO.EventName.ToString();
            AddressLB.Text = $"{eventDTO.DetailAddress}, {eventDTO.wardName}, {eventDTO.districtName}, {eventDTO.cityName}";
            DateTimeLB.Text = $"{eventDTO.StartDate?.ToString("dd/MM/yyyy")} - {eventDTO.EndDate?.ToString("dd/MM/yyyy")}";
            TimeLB.Text = eventDTO.time;
            Image image;
            using (MemoryStream ms = new MemoryStream(eventDTO.EventImage))
            {
                image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
            purposeTXT.Text = eventDTO.purpose;
            DescriptionTXT.Text = eventDTO.description;
            VolunteerCountLB.Text = eventDTO.RegisterCount.ToString();
            if (EventBLL.Event_CheckVolunteerLike(eventDTO.EventID, curVol.VolunteerID))
            {
                LikeBTN.Text = "Đã thích";
                LikeBTN.Enabled = false;
            }
            if (EventBLL.Event_CheckVolunteerRegister(eventDTO.EventID, curVol.VolunteerID))
            {
                ParticipateBTN.Text = "Đã đăng ký";
                ParticipateBTN.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (eventModel.isBackTo == "HISTORYEVENT")
            {
                BackToEvents(this, new EventArgs());
            }
            else
            {
                BackToEventsMain(this, new EventArgs());
            }
        }

        private void LikeBTN_Click(object sender, EventArgs e)
        {

            if (EventBLL.Event_LikeEvent(eventModel.EventID))
            {
                var newEventDetail = EventBLL.Event_ById(eventModel.EventID);
                LoadDetailEvent(newEventDetail);
                LikeBTN.Text = "Đã thích";
                LikeBTN.Enabled = false;
            }
          
        }

        private void ParticipateBTN_Click(object sender, EventArgs e)
        {
            Event.EventRegistrationForm.RegistrationForm registrationForm = new Event.EventRegistrationForm.RegistrationForm(eventModel);
            registrationForm.Show();
        }
    
    }
    
}
