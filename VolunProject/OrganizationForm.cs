using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.DTO;
using VolunProject.UserInterface.CheckIn_CheckOut;
using VolunProject.UserInterface.CheckIn_CheckOut.EventList;
using VolunProject.UserInterface.CheckIn_CheckOut.ProcessingEventControl;
using VolunProject.UserInterface.Event;
using VolunProject.UserInterface.Event.EventControl;
using VolunProject.UserInterface.Event.EventHistoryControl;
using VolunProject.UserInterface.Login;

namespace VolunProject
{
    public partial class OrganizationForm : Form
    {
        bool sidebarExpand = false;
        private UserControl activeForm;
        public static event EventHandler signOutEventOr;
        public OrganizationForm()
        {
            InitializeComponent();
            ApproveVolunteerBTN_Click(this, new EventArgs());
            sub();
        }

        private void sub()
        {
            EventControl.DetailEvent += EventControl_DetailEvent;
            ProcessingEventControl.OpenRegistrationAprroveListEvent += ProcessingEventControl_OpenRegistrationAprroveListEvent;
            RegistrationApproveList.OnBackEvent += DiemDanhBTN_Click;
          
        }



        private void ProcessingEventControl_OpenRegistrationAprroveListEvent(object sender, EventArgs e)
        {
            var eventDTO = sender as EventDTO;
            OpenChildForm(new UserInterface.CheckIn_CheckOut.RegistrationApproveList(eventDTO.EventID), sender);
        }

        private void EventControl_DetailEvent(object sender, EventArgs e)
        {
            var eventControll = sender as EventControl;
            OpenChildForm(new UserInterface.EventDetail.EventDetail_UC(eventControll.EventModel), sender);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        public void OpenChildForm(UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            this.MainPanel.Controls.Add(a);
            this.MainPanel.Tag = a;
        }
        private void CreateEventButoon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.AddNewEvent.AddNewEvent(), sender);
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.OrganizationEvent.OrganizationEvent(), sender);
        }

        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            signOutEventOr(this, new EventArgs());
        }

        private void ApproveVolunteerBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.OrganizationRegisterList.OrganizationRegisterList(), sender);
        }

        private void notifyBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.NotificationList.NotificationList(), sender);
        }

        private void DiemDanhBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.CheckIn_CheckOut.EventList.ProcessingEventList(), sender);
        }
    }
}
