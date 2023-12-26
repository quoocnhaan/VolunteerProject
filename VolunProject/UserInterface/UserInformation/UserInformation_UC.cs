using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.UserInterface.UserInformation
{
    public partial class UserInformation_UC : UserControl
    {
        private bool gender;

        public UserInformation_UC()
        {
            InitializeComponent();
            genderCB.Items.Add(new {genderValue = true,genderDisplay = "Nam"});
            genderCB.Items.Add(new {genderValue = false, genderDisplay = "Nữ" });
            genderCB.DisplayMember = "genderDisplay";
            genderCB.ValueMember = "genderValue";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void curPasswordTB_TextChanged(object sender, EventArgs e)
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

        private void districtCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var district = (int)districtCB.SelectedValue;
            var wardtlist = WardBLL.Ward_ByDistrictId(district);
            wardCB.DisplayMember = "tenXaPhuong";
            wardCB.ValueMember = "ID";
            wardCB.DataSource = wardtlist;
        }

        private void UserInformation_UC_Load(object sender, EventArgs e)     
        {
            var curUser =  OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            var citylist = CityBLL.City_List();
            cityCB.DisplayMember = "tenTinhThanhPho";
            cityCB.ValueMember = "ID";
            cityCB.DataSource = citylist;
            if (curVol.CityId != null)
            {
                cityCB.SelectedValue = curVol.CityId;
                districtCB.SelectedValue = curVol.DistrictId;
                wardCB.SelectedValue = curVol.WardId;
            }
            scoresLB.Text = curVol.PrestigeScore.ToString();
            userNameTB.Text = curVol.Name;
            accountNameLB.Text = curUser.AccountName;
            descriptionTB.Text = curVol.Description;
            addressTB.Text = curVol.AddressDetail;
            RankingDTO rankingDTO = RankingBLL.getRankingByID(curVol.RankId);
            Image image1,image2;
            using (MemoryStream ms1 = new MemoryStream(curUser.ImageUS))
            {
                image1 = Image.FromStream(ms1);
                userImg.Image = image1;
            }
            using (MemoryStream ms2 = new MemoryStream(rankingDTO.RankImage))
            {
                image2 = Image.FromStream(ms2);
                rankingPB.Image = image2;
            }
            
            bool? genderNullable = curVol.Gender;
            string gender = genderNullable.HasValue ? (genderNullable.Value ? "Nam" : "Nữ") : "";
            int index = genderCB.FindStringExact(gender);
            if (index != -1)
            {
                genderCB.SelectedIndex = index;
            }
            else
            {
                genderCB.SelectedIndex = 0;
            }
            emailTB.Text = curVol.Email;
            phoneTB.Text = curVol.PhoneNumber;
        }
        private void wardCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;

                    userImg.Image = Image.FromFile(selectedFileName);
                    userImg.SizeMode = PictureBoxSizeMode.Zoom;

                    string filePath = selectedFileName;

                }
            }
        }

        private void accountNameLB_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.EndsWith("@gmail.com");
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng số điện thoại
            // Yêu cầu ít nhất 8 chữ số
            Regex regex = new Regex(@"^\d{8,}$");
            return regex.IsMatch(phoneNumber);
        }
        private bool ContainsNumbersOrSpecialCharacters(string name)
        {
            // Kiểm tra xem chuỗi có chứa số hoặc ký tự đặc biệt không
            foreach (char c in name)
            {
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool ContainsSpecialCharacters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    return true;
                }
            }
            return false;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string phone = phoneTB.Text;
            string name = userNameTB.Text;
            string address = addressTB.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
                VolunteerDTO vol = new VolunteerDTO();
                byte[] img = OtherFunction.ImageToByteArray(userImg.Image);
                if(name == "")
                {
                    label16.Text = "Họ và tên không được trống";
                    label16.Visible = true;
                    return;
                }
                if (email == "")
                {
                    label16.Text = "Số điện thoại không được để trống";
                    label16.Visible = true;
                    return;
                }
                if (phone == "")
                {
                    label16.Text = "Số điện thoại không được để trống";
                    label16.Visible = true;
                    return;
                }
                if (address == "")
                {
                    label16.Text = "Địa chỉ không được để trống";
                    label16.Visible = true;
                    return;
                }
                if (ContainsNumbersOrSpecialCharacters(name))
                {
                    label16.Text = "Họ và tên không được chứa số hoặc ký tự đặc biệt";
                    label16.Visible = true;
                    return;
                }
                vol.Name = name;
                if (!IsValidEmail(email)) {
                    label16.Text = "Địa chỉ email không hợp lệ. Vui lòng nhập đúng định dạng @gmail.com";
                    label16.Visible = true;
                    return;
                }
                if (VolunteerBLL.checkEmail_Information(curVol.VolunteerID,email))
                {
                    label16.Text = "Địa chỉ email đã được sử dụng";
                    label16.Visible = true;
                    return;
                }
                vol.Email = email;
                if (!IsValidPhoneNumber(phone)) {
                    label16.Text = "Số điện thoại không hợp lệ";
                    label16.Visible = true;
                    return;
                }
                vol.PhoneNumber = phone;
                vol.Gender = gender;
                vol.Description = descriptionTB.Text;
                vol.CityId = (int)cityCB.SelectedValue;
                vol.WardId = (int)wardCB.SelectedValue;
                vol.DistrictId = (int)districtCB.SelectedValue;
                if (ContainsSpecialCharacters(address))
                {
                    label16.Text = "Địa chỉ không được chứa ký tự đặc biệt";
                    label16.Visible = true;
                    return;
                }
                vol.AddressDetail = address;
                vol.BirthDate = DateTime.Now;
                if(VolunteerBLL.UpdateVolunteer(vol, img))
                {
                    MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                    label16.Visible = false;
                }
            }
        }

        private void genderCB_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void genderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            gender = cb.SelectedIndex > 0 ? false : true;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string curPassword = curPasswordTB.Text;
                string confirmPassword = confirmPasswordTB.Text;
                string newPassword = newPasswordTB.Text;
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                if (curPassword == "")
                {
                    lb1.Text = "Vui lòng nhập mật khẩu hiện tại";
                    lb1.Visible = true;
                }
                else if (newPassword == "")
                {
                    lb1.Text = "Vui lòng nhập mật khẩu mới";
                    lb1.Visible = true;
                }
                else if (confirmPassword == "")
                {
                    lb1.Text = "Vui lòng xác nhận mật khẩu";
                    lb1.Visible = true;
                }
                else if (curPasswordTB.Text != curUser.Password)
                {
                    lb1.Text = "Mật khẩu không đúng";
                    lb1.Visible = true;
                }
                else if (newPassword != confirmPassword)
                {
                    lb1.Text = "Mật khẩu xác nhận không trùng khớp";
                    lb1.Visible = true;
                }
                else if (newPassword == curUser.Password)
                {
                    lb1.Text = "Mật khẩu mới trùng với mật khẩu cũ";
                    lb1.Visible = true;
                }
                else if (newPassword.Length < 8)
                {
                    lb1.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                    lb1.Visible = true;
                }
                else
                {
                    AccountBLL.changePassword(curUser.AccountName, newPasswordTB.Text);
                    lb1.Visible = false;
                    curPasswordTB.Text = "";
                    newPasswordTB.Text = "";
                    confirmPasswordTB.Text = "";
                    MessageBox.Show("Đổi mật khẩu thành công !","Thông báo",MessageBoxButtons.OK);
                }
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void show1_Click(object sender, EventArgs e)
        {
            close1.BringToFront();
            curPasswordTB.PasswordChar = '\0';
        }

        private void close1_Click(object sender, EventArgs e)
        {
            show1.BringToFront();
            curPasswordTB.PasswordChar = '●';
        }

        private void show2_Click(object sender, EventArgs e)
        {
            close2.BringToFront();
            newPasswordTB.PasswordChar = '\0';
        }

        private void close2_Click(object sender, EventArgs e)
        {
            show2.BringToFront();
            newPasswordTB.PasswordChar = '●';
        }

        private void close3_Click(object sender, EventArgs e)
        {
            show3.BringToFront();
            confirmPasswordTB.PasswordChar = '●';
        }

        private void show3_Click(object sender, EventArgs e)
        {
            close3.BringToFront();
            confirmPasswordTB.PasswordChar = '\0';
        }

        private void userImg_Click(object sender, EventArgs e)
        {

        }
    }
}
