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

namespace VolunProject.UserInterface.Event.OrganizationEvent
{
    public partial class OrganizationEvent : UserControl
    {
        public OrganizationEvent()
        {
            InitializeComponent();
            PopulateCardList();
        }

        private void PopulateCardList()
        {
            // Assuming you have a list of data representing your cards
            // For demonstration purposes, I'm using a simple string array
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var events = EventBLL.Event_ByOrganizationId(curUser.OrganizationID);

            // Set up a FlowLayoutPanel to host the cards
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1700, 722);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (EventDTO cardText in events)
            {
                EventControl.EventControl cardControl = new EventControl.EventControl(cardText);
                EventflowLayoutPanel.Controls.Add(cardControl);
            }
            panel1.Controls.Add(EventflowLayoutPanel);
        }
    }
}
