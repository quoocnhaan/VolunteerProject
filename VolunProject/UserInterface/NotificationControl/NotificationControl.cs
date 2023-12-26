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
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.NotificationControl
{
    public partial class NotificationControl : UserControl
    {
        public NotificationControl(NotificationDTO notificationDTO)
        {
            InitializeComponent();
            LoadControl(notificationDTO);
        }
        private string CustomTime(DateTime dateTime)
        {
            TimeSpan timeMinus = DateTime.Now - dateTime;
            int daysDifference = timeMinus.Days;
            int hoursDifference = timeMinus.Hours;
            int minutesDifference = timeMinus.Minutes;
            return $"{daysDifference}d, {hoursDifference}h, {minutesDifference}m";
        }
        private void LoadControl(NotificationDTO notificationDTO)
        {
            Image image1;
            using (MemoryStream ms1 = new MemoryStream(notificationDTO.NotiImg))
            {
                image1 = Image.FromStream(ms1);
                NotiImg.Image = image1;
            }
            NotiContentTXT.Text = notificationDTO.NotificationContent;
            TimeLB.Text = CustomTime(notificationDTO.createDate);
            DateTimeLB.Text = notificationDTO.createDate.ToString("dd/MM/yyyy");
        }
    }
}
