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
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.History
{
    public partial class RewardHistoryControl : UserControl
    {
        public RewardHistoryControl(RewardDTO rewardDTO)
        {
            InitializeComponent();
            rewardName.Text = rewardDTO.RewardName;
            Image image;
            using (MemoryStream ms = new MemoryStream(rewardDTO.RewardImg))
            {
                image = Image.FromStream(ms);
                rewardImg.Image = image;
            }
            date.Text = "Ngày đổi: " + rewardDTO.RedeemDate.ToString();
            point.Text = rewardDTO.RedeemPoint.ToString();
        }

        private void rewardName_Click(object sender, EventArgs e)
        {

        }
    }
}
