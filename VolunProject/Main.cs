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
using VolunProject.LoginForm;
using VolunProject.UserInterface.Event.EventControl;
using VolunProject.UserInterface.Event.EventHistoryControl;
using VolunProject.UserInterface.EventDetail;
using VolunProject.UserInterface.Home;
using VolunProject.UserInterface.Redeem;
//using VolunProject.Data.BLL;

namespace VolunProject
{

    public partial class Main : Form
    {
        public static event EventHandler signOutEvent;
        bool sidebarExpand = false;
        private UserControl activeForm;
        public Main()
        {
            InitializeComponent();
            sub();
        }
        private void sub()
        {
            EventControl.DetailEvent += EventControl_DetailEvent;
            EventDetail_UC.BackToEvents += EventDetail_UC_BackToEvents;
            RedeemControl.loadEvent += RedeemControl_loadEvent;
            LoginForm.LoginForm.loginEvent += Main_Load;
            CreatePost_Form.LoadEvent += Main_Load;
            EventHistoryControl.DetailEvent2 += EventControl_DetailEvent;
            EventDetail_UC.BackToEventsMain += EventDetail_UC_BackToEventsMain; ;

        }

        private void EventDetail_UC_BackToEventsMain(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.Event_UC(), sender);
        }

        private void CreatePost_Form_LoadEvent(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_loginEvent(object sender, EventArgs e)
        {
            
        }

        private void EventDetail_UC_BackToEvents(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.History.History_UC("EVENT"), sender);
        }

        private void RedeemControl_loadEvent(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Redeem.Redeem_UC(), sender);
        }
        private void EventControl_DetailEvent(object sender, EventArgs e)
        {
            var eventControll = sender as EventDTO;
            OpenChildForm(new UserInterface.EventDetail.EventDetail_UC(eventControll), sender);
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
            //ActivateButton(btnSender);
            this.MainPanel.Controls.Add(a);
            this.MainPanel.Tag = a;
            //lblTitle.Text = (btnSender as Button).Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.UserInformation.UserInformation_UC(), sender);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Home.Home_UC(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.Event_UC(), sender);
        }

        private void rewardsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Redeem.Redeem_UC(), sender);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.AddNewEvent.AddNewEvent(), sender);
        }

        private void signOutButoon_Click(object sender, EventArgs e)
        {
            signOutEvent(this, new EventArgs());
        }

        private void createReward_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Redeem.CreateReward(), sender);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.History.History_UC("REWARD"), sender);
        }

        private void MainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Home.Home_UC(), sender);
        }

        private void NotificationBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.NotificationList.NotificationList(), sender);
        }
    }
}
