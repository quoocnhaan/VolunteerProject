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
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VolunProject.UserInterface.CheckIn_CheckOut
{
    public partial class RegistrationApproveList : UserControl
    {
        public static event EventHandler OnBackEvent;
        private string eventIdModel;
        private List<RegistrationVolunteerDTO> registrationVolunteerDTOs;
        public RegistrationApproveList(string eventID)
        {
           
            VolunteerSearchDTO volunteerSearchDTO = new VolunteerSearchDTO()
            {
                Name = ""
            };
            InitializeComponent();
            sub();
            LoadData(eventID, volunteerSearchDTO);
            StatusDefault();
            var kiet = registrationVolunteerDTOs.Select(x => x.Name).ToList();
            OtherFunction.autocomplete(SearchName, kiet);
            



        }
        private void sub()
        {

            RegistrationApproveControl.RegistrationApproveControl.ResetDataEvent += RegistrationApproveControl_ResetDataEvent;
        }

        private void RegistrationApproveControl_ResetDataEvent(object sender, EventArgs e)
        {
            VolunteerSearchDTO volunteerSearchDTO = new VolunteerSearchDTO()
            {
                Name = ""
            };
            LoadData(eventIdModel, volunteerSearchDTO);
        }

        public void StatusDefault()
        {
            StatusDTO status = new StatusDTO("C", "Chưa Check");
            StatusDTO status2 = new StatusDTO("E", "Đã Check-In");
            StatusDTO status3 = new StatusDTO("A", "Hoàn thành");
            filterCB.ValueMember = "status";
            filterCB.DisplayMember = "statusName";
            filterCB.DataSource = (new List<StatusDTO>() { status, status2, status3 }.ToArray());
        }
        private void LoadData(string eventID, VolunteerSearchDTO volunteerSearchDTO)
        {
            notiPanel.Controls.Clear();
            eventIdModel = eventID;
            // var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var volunteers = VolunteerBLL.Volunteer_ByEventID(eventID, volunteerSearchDTO);
            registrationVolunteerDTOs = volunteers.ToList();
            EventNameLB.Text = EventBLL.Event_ById(eventID).EventName;
            // Set up a FlowLayoutPanel to host the cards
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1700, 722);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (RegistrationVolunteerDTO cardText in volunteers)
            {
                RegistrationApproveControl.RegistrationApproveControl cardControl = new RegistrationApproveControl.RegistrationApproveControl(cardText);
                EventflowLayoutPanel.Controls.Add(cardControl);
            }
            notiPanel.Controls.Add(EventflowLayoutPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnBackEvent(this, new EventArgs());
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sta = filterCB.SelectedValue as string;
            LoadData(eventIdModel, Filter(sta));
        }
        private VolunteerSearchDTO Filter(string sta)
        {
            if (sta == "C")
            {
                VolunteerSearchDTO volunteerSearchDTO = new VolunteerSearchDTO()
                {
                    CheckIn = false,
                    CheckOut = false,
                    Name = ""

                };
                return volunteerSearchDTO;
            }
            else if (sta == "E")
            {
                VolunteerSearchDTO volunteerSearchDTO = new VolunteerSearchDTO()
                {
                    CheckIn = true,
                    CheckOut = false,
                    Name = ""

                };
                return volunteerSearchDTO;
            }
            else
            {
                VolunteerSearchDTO volunteerSearchDTO = new VolunteerSearchDTO()
                {
                    CheckIn = true,
                    CheckOut = true,
                    Name = ""
                };
                return volunteerSearchDTO;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string nameSearch = SearchName.Text;
            if (e.KeyCode == Keys.Enter)
            {
                var fil = Filter(filterCB.SelectedValue as string);
                fil.Name = nameSearch;
                LoadData(eventIdModel, fil);
            }
        }
    }
}
