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

namespace VolunProject.UserInterface.Redeem
{
    public partial class Redeem_UC : UserControl
    {
        public Redeem_UC()
        {
            InitializeComponent();
            createRedeem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void createRedeem()
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            var allRewardDTOs = RewardBLL.getAllRewards();
            var rewardByVolunteerID = RewardBLL.getRewardsByVolunteerID(curVol.VolunteerID);
            var unredeemReward = allRewardDTOs.Except(rewardByVolunteerID, new OtherFunction.RewardComparer());
            listRedeemFlowlayoutpanel.AutoScroll = true;
            listRedeemFlowlayoutpanel.FlowDirection = FlowDirection.LeftToRight;
            foreach (var item in unredeemReward)
            {
                RedeemControl redeemControl = new RedeemControl(item,true);
                listRedeemFlowlayoutpanel.Controls.Add(redeemControl);
            }
            foreach (var item in rewardByVolunteerID)
            {
                RedeemControl redeemControl = new RedeemControl(item,false);
                listRedeemFlowlayoutpanel.Controls.Add(redeemControl);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listRedeemFlowlayoutpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Redeem_UC_Load(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            lb1.Text = curVol.RewardPoint.ToString();
        }
    }
}
