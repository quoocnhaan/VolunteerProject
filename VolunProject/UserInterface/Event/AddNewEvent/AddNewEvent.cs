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
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.AddNewEvent
{
    public partial class AddNewEvent : UserControl
    {
        public AddNewEvent()
        {
            InitializeComponent();
        }

        private void AddNewEvent_Load(object sender, EventArgs e)
        {
            var citylist = CityBLL.City_List();
            CityCB.DisplayMember = "tenTinhThanhPho";
            CityCB.ValueMember = "ID";
            CityCB.DataSource = citylist;

            var cateList = CategoryBLL.EventCategory_List();
            EventTypeCB.DisplayMember = "CategoryName";
            EventTypeCB.ValueMember = "CategoryID";
            EventTypeCB.DataSource = cateList;

        }

        private void CityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var city =(int) CityCB.SelectedValue;
            var districtlist = DistrictBLL.District_ByCityId(city);
            DistrictCB.DisplayMember = "tenQuanHuyen";
            DistrictCB.ValueMember = "ID";
            DistrictCB.DataSource = districtlist;
        }

        private void WardCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DistrictCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var district = (int)DistrictCB.SelectedValue;
            var wardtlist = WardBLL.Ward_ByDistrictId(district);
            WardCB.DisplayMember = "tenXaPhuong";
            WardCB.ValueMember = "ID";
            WardCB.DataSource = wardtlist;
        }

        private void UploadBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                
                    string selectedFileName = openFileDialog.FileName;

                    EventImageBox.Image = Image.FromFile(selectedFileName);
                    EventImageBox.SizeMode = PictureBoxSizeMode.Zoom;

                    string filePath = selectedFileName;
                   
                }
            }
        }
        
        private void AddEventBTN_Click(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            EventDTO eventDTO = new EventDTO();
            eventDTO.EventName = EventNameTB.Text;
            eventDTO.DetailAddress = DetailAddressTB.Text;
            eventDTO.CategoryId = (string)EventTypeCB.SelectedValue;
            eventDTO.CityId = (int)CityCB.SelectedValue;
            eventDTO.DistrictId = (int)DistrictCB.SelectedValue;
            eventDTO.WardId = (int)WardCB.SelectedValue;
            eventDTO.StartDate = StartDate.Value;
            eventDTO.EndDate = EndDate.Value;
            if (EventImageBox.Image != null)
            {
                eventDTO.EventImage = OtherFunction.ImageToByteArray(EventImageBox.Image);
            }
            else
            {
                Image image = VolunProject.Properties.Resources.imagedd;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    eventDTO.EventImage = ms.ToArray();
                }
            }
            eventDTO.purpose = PurposeTB.Text;
            eventDTO.description = DescriptionTB.Text;
            eventDTO.time = timeTXT.Text;
            if (EventBLL.Event_Add(eventDTO))
            {
                NotificationDTO notificationDTO = new NotificationDTO();
                notificationDTO.NotificationContent = $"Sự kiện {eventDTO.EventName} vừa được thêm vào lúc {DateTime.Now}.";
                notificationDTO.AccountID = curUser.AccountID;
                if (EventImageBox.Image != null)
                {
                    notificationDTO.NotiImg = OtherFunction.ImageToByteArray(EventImageBox.Image);
                }
                else
                {
                    Image image = VolunProject.Properties.Resources.imagedd;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        notificationDTO.NotiImg = ms.ToArray();
                    }
                }
                if (NotificationBLL.Notification_Add(notificationDTO))
                {
                    MessageBox.Show("Thêm sự kiện thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        
    }
}
