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
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace VolunProject.UserInterface.Redeem
{
    public partial class RedeemControl : UserControl
    {
        RewardDTO curReward = new RewardDTO();
        public static event EventHandler loadEvent;
        public RedeemControl(RewardDTO rewardDTO, bool? state)
        {              
            InitializeComponent();
            curReward = rewardDTO;
            redeemButton.Text = rewardDTO.RedeemPoint.ToString();
            lb1.Text = rewardDTO.RewardName;
            if (state == false)
            {
                redeemButton.Enabled = false;
                redeemButton.Text = "";
                redeemButton.Image = VolunProject.Properties.Resources.icons8_check_48__1_;
            }
            Image image;
            using (MemoryStream ms = new MemoryStream(rewardDTO.RewardImg))
            {
                image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi quà ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Button btn = sender as Button;
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
                int point = Convert.ToInt16(btn.Text);
                if (curVol.RewardPoint >= point)
                {
                    VolunteerRewardDTO volunteerRewardDTO = new VolunteerRewardDTO();
                    volunteerRewardDTO.VolunteerID = curVol.VolunteerID;
                    volunteerRewardDTO.RewardID = curReward.RewardID;
                    volunteerRewardDTO.RedeemDate = DateTime.Now;
                    volunteerRewardDTO.state = true;
                    RewardBLL.updateState(curReward.RewardID);
                    VolunteerRewardBLL.AddVolunteerReward(volunteerRewardDTO, curVol.VolunteerID, point);
                    MessageBox.Show("Đổi quà thành công", "Thông báo", MessageBoxButtons.OK);
                    loadEvent(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Điểm không đủ để đổi quà", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
