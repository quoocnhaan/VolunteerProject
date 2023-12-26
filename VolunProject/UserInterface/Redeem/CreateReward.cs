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

namespace VolunProject.UserInterface.Redeem
{
    public partial class CreateReward : UserControl
    {
        public CreateReward()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            RewardDTO rewardDTO = new RewardDTO();
            rewardDTO.RewardName = nameTB.Text;
            rewardDTO.RedeemPoint = Convert.ToInt16(scoresTB.Text);
            rewardDTO.RewardImg = OtherFunction.ImageToByteArray(pictureBox.Image);
            RewardBLL.createReward(rewardDTO);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(selectedFileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    string filePath = selectedFileName;
                }
            }
        }
    }
}
