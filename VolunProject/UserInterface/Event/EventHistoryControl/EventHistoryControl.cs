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
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.EventHistoryControl
{
    public partial class EventHistoryControl : UserControl
    {
        private EventDTO EventModel;
        public static event EventHandler LoadHistoryEvent;
        public static event EventHandler DetailEvent2;
        public EventHistoryControl(EventDTO eventDTO)
        {

            InitializeComponent();
            LoadEvent(eventDTO);
        }

        private void JoinEventBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
                if (EventBLL.Registration_Cancel(EventModel.EventID, curVol.VolunteerID))
                {
                    DialogResult re =  MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                    if (re == DialogResult.OK)
                    {
                        LoadHistoryEvent(this, new EventArgs());
                    }
                }
            }
        }
        private void LoadEvent(EventDTO eventDTO)
        {
         
            
            EventModel = eventDTO;
            if (eventDTO.status == "A" || eventDTO.status == "R")
            {
                CancelEventBTN.Enabled = false;
            }
            eventTitle.Text = eventDTO.EventName.ToString();
            addressLB.Text = $"{eventDTO.DetailAddress}, {eventDTO.wardName}, {eventDTO.districtName}, {eventDTO.cityName}";
            DateTimeLB.Text = $"{eventDTO.StartDate?.ToString("dd/MM/yyyy")} - {eventDTO.EndDate?.ToString("dd/MM/yyyy")}";
            TimeLB.Text = eventDTO.time;
            Image image;
            using (MemoryStream ms = new MemoryStream(eventDTO.EventImage))
            {
                image = Image.FromStream(ms);
                EventImageBox.Image = image;
            }

        }

        private void DetailEventBtn_Click(object sender, EventArgs e)
        {
            EventModel.isBackTo = "HISTORYEVENT";
            DetailEvent2(EventModel, new EventArgs());
        }
    }
}
