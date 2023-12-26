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
using VolunProject.UserInterface.Event.EventRegistrationForm;

namespace VolunProject.UserInterface.Event
{
    public partial class Event_UC : UserControl
    {
        private List<EventDTO> eventDTOs;
        public Event_UC()
        {
            InitializeComponent();
            sub();
             EventDTO eventDTO = new EventDTO();
            PopulateCardList(eventDTO);
           
            var kiet = eventDTOs.Select(x => x.EventName).ToList();
            OtherFunction.autocomplete(Searchtxt, kiet);


            var citylist = CityBLL.City_List();
            cityCB.DisplayMember = "tenTinhThanhPho";
            cityCB.ValueMember = "ID";
            cityCB.DataSource = citylist;

            var category = CategoryBLL.EventCategory_List();
            categoryCB.DisplayMember = "CategoryName";
            categoryCB.ValueMember = "CategoryID";
            categoryCB.DataSource = category;
        }

        private void sub()
        {
            RegistrationForm.LoadAlllEvent += RegistrationForm_LoadAlllEvent;
        }

        private void RegistrationForm_LoadAlllEvent(object sender, EventArgs e)
        {
            EventDTO eventDTO = new EventDTO();
            PopulateCardList(eventDTO);
        }

        private void PopulateCardList(EventDTO eventDTO)
        {
            // Assuming you have a list of data representing your cards
            // For demonstration purposes, I'm using a simple string array
            //var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");

           

            panel1.Controls.Clear();
            var events = EventBLL.Event_List(eventDTO);
            eventDTOs = events.ToList();
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

        private void Event_UC_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scrollablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var city = (int)cityCB.SelectedValue;
            var districtlist = DistrictBLL.District_ByCityId(city);
            districtCB.DisplayMember = "tenQuanHuyen";
            districtCB.ValueMember = "ID";
            districtCB.DataSource = districtlist;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            EventDTO eventDTO = new EventDTO();
            eventDTO.StartDate = startdate.Value;
            eventDTO.EndDate = enddate.Value;
            eventDTO.EventName = Searchtxt.Text;
            eventDTO.CategoryId = (string) categoryCB.SelectedValue;
            eventDTO.CityId = (int) cityCB.SelectedValue;
            eventDTO.state = true;
            eventDTO.DistrictId = (int) districtCB.SelectedValue;
            PopulateCardList(eventDTO);
        }

        private void AllEventBTN_Click(object sender, EventArgs e)
        {
            EventDTO eventDTO = new EventDTO();
            PopulateCardList(eventDTO);
        }
    }
   /* public class CardControl : UserControl
    {
        public CardControl(string cardText)
        {
            // Customize the appearance of the card control
            Size = new System.Drawing.Size(1100, 100);
            BackColor = System.Drawing.Color.LightGray;
            Margin = new Padding(15);
            // Add a label to display the card text
            Label label = new Label();
            label.Text = cardText;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Add the label to the card control
            Controls.Add(label);
        }
    }*/
}
