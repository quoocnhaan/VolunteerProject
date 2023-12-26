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
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.UserInterface.Event.OrganizationRegisterList
{
    public partial class OrganizationRegisterList : UserControl
    {
        private RegisterFormSearchDTO RegisterFormSearchDTO;
        private bool condition = false;
       // private List<RegisterVolunteerFormDTO> registerVolunteerFormDTOs;
        private AccountDTO curUser;
        public OrganizationRegisterList() 
        {
            InitializeComponent();
            sub();
            condition = false;
        }
        private void sub()
        {
            OrganizationRegisterFormControl.OrganizationRegisterFormControl.LoadEvent += OrganizationRegisterFormControl_LoadEvent;
        }

        private void OrganizationRegisterFormControl_LoadEvent(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void OrganizationRegisterList_Load(object sender, EventArgs e)
        {
            RegisterFormSearchDTO = new RegisterFormSearchDTO()
            {
                eventID = "",
                status = ""
            };
            curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            Loaddata();
            var events = EventBLL.Event_ByOrganizationId(curUser.OrganizationID);
            EventListCB.DisplayMember = "EventName";
            EventListCB.ValueMember = "EventID";
            EventListCB.DataSource = events;
            StatusDefault();
            condition = true;


        }
        private void Loaddata() {

            registerformlist.Controls.Clear();
            var eventlist = EventBLL.Event_GetAllVolunteerRegistration_ByOranizationId(curUser.OrganizationID, RegisterFormSearchDTO);
            RegisterCountLB.Text = eventlist.Count.ToString();
            //  registerVolunteerFormDTOs = eventlist.ToList();
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1700, 722);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (RegisterVolunteerFormDTO cardText in eventlist)
            {
                OrganizationRegisterFormControl.OrganizationRegisterFormControl cardControl = new OrganizationRegisterFormControl.OrganizationRegisterFormControl(cardText);
                EventflowLayoutPanel.Controls.Add(cardControl);
            }
            registerformlist.Controls.Add(EventflowLayoutPanel);
        }
        public void StatusDefault()
        {
            
            StatusDTO status2 = new StatusDTO("C", "Chờ duyệt");
            StatusDTO status = new StatusDTO("A", "Đã duyệt");
            StatusDTO status3 = new StatusDTO("R", "Từ chối");
            StatusDTO status4 = new StatusDTO("", "Tất cả");
            StatusCB.ValueMember = "status";
            StatusCB.DisplayMember = "statusName";
      //      StatusCB.SelectedValue = "C";
            StatusCB.DataSource = (new List<StatusDTO>() {  status4, status2, status, status3 }.ToArray());
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (condition)
            {
                RegisterFormSearchDTO.status = (string)StatusCB.SelectedValue;
                Loaddata();
            }
        }

        private void EventListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (condition)
            {
                RegisterFormSearchDTO.eventID = (string)EventListCB.SelectedValue;
                 Loaddata();
            }
        }
    }
}
