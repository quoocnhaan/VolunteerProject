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
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.CheckIn_CheckOut.ProcessingEventControl
{
    public partial class ProcessingEventControl : UserControl
    {
        private EventDTO EventModel;
        public static event EventHandler OpenRegistrationAprroveListEvent;
        public ProcessingEventControl(EventDTO eventDTO)
        {
            InitializeComponent();
            LoadEvent(eventDTO);
        }
        private void LoadEvent(EventDTO eventDTO)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            EventModel = eventDTO;
            
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
        private void AttendanceBTN_Click(object sender, EventArgs e)
        {
            OpenRegistrationAprroveListEvent(EventModel, new EventArgs());
        }
    }
}
