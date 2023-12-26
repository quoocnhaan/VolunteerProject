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
using static VolunProject.OtherFunction;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.UserRegisterInformation
{
    public partial class UserRegisterInformation : Form
    {
        private VolunteerDTO VolunteerDTO;
        public UserRegisterInformation(string volunteerID)
        {
            
            InitializeComponent();
            var volunteer = VolunteerBLL.GetVolunteer_ByVolunId(volunteerID);
            VolunteerDTO = volunteer;
            LoadForm(volunteer);
        }
        private void LoadForm(VolunteerDTO volunteerDTO)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
           // var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            CityTXT.Text = CityBLL.City_ById(volunteerDTO.CityId).tenTinhThanhPho;
            DistrictNameTXT.Text = DistrictBLL.District_ById(volunteerDTO.DistrictId).tenQuanHuyen;
            WardNameTXT.Text = WardBLL.Ward_ById(volunteerDTO.WardId).tenXaPhuong;
            scoresLB.Text = volunteerDTO.PrestigeScore.ToString();
            userNameTB.Text = volunteerDTO.Name;
            accountNameLB.Text = AccountBLL.GetAccountByID(volunteerDTO.AccountID).AccountName;
            descriptionTB.Text = volunteerDTO.Description;
            addressTB.Text = volunteerDTO.AddressDetail;
            RankingDTO rankingDTO = RankingBLL.getRankingByID(volunteerDTO.RankId);
            Image image1, image2;
            using (MemoryStream ms1 = new MemoryStream(AccountBLL.GetAccountByID(volunteerDTO.AccountID).ImageUS))
            {
                image1 = Image.FromStream(ms1);
                userImg.Image = image1;
            }
            using (MemoryStream ms2 = new MemoryStream(rankingDTO.RankImage))
            {
                image2 = Image.FromStream(ms2);
                rankingPB.Image = image2;
            }

            genderTXT.Text = volunteerDTO.Gender ? "Nam" : "Nữ";
            emailTB.Text = volunteerDTO.Email;
            phoneTB.Text = volunteerDTO.PhoneNumber;
        }
        private void UserRegisterInformation_Load(object sender, EventArgs e)
        {
            LoadForm(VolunteerDTO);
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
