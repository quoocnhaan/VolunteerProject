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
using VolunProject.UserInterface.Event.EventControl;

namespace VolunProject.UserInterface.NotificationList
{
    public partial class NotificationList : UserControl
    {
        public NotificationList()
        {
            InitializeComponent();
            PopulateCardList();
        }
        private void PopulateCardList()
        {
            // Assuming you have a list of data representing your cards
            // For demonstration purposes, I'm using a simple string array
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var notifications = NotificationBLL.Notification_ByAccountID(curUser.AccountID);
            // Set up a FlowLayoutPanel to host the cards
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1700, 722);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (NotificationDTO cardText in notifications)
            {
                NotificationControl.NotificationControl notiControl = new NotificationControl.NotificationControl(cardText);
                EventflowLayoutPanel.Controls.Add(notiControl);
            }
            notiPanel.Controls.Add(EventflowLayoutPanel);
        }

        private void NotificationList_Load(object sender, EventArgs e)
        {
            PopulateCardList();
        }
    }
}
