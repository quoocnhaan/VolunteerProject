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
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Home
{
    public partial class CreatePost_UC : UserControl
    {
        public CreatePost_UC()
        {
            InitializeComponent();

        }
        private void ResizePictureBox()
        {
            if (postImg.Image != null)
            {
                int newWidth = postImg.Image.Width;
                int newHeight = postImg.Image.Height;
                if (newWidth > 703) newWidth = 703;
                if (newHeight > 658) newWidth = 658;
                postImg.Width = newWidth;
                postImg.Height = newHeight;
                postButton.Location = new Point(3, 38 + newHeight);
                backButton.Location = new Point(106, 38 + newHeight);
                this.Height += newHeight;
            }
        }
        private void postTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = postTextbox.Text.Length;
            if (charCount <= 80) postTextbox.Height = 24;
            else
            {
                int line = charCount / 80;
                postTextbox.Height = 22 * (line + 1);
                panel2.Location = new Point(24, 128 + line * 22);
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            PostDTO postDTO = new PostDTO();
            postDTO.Caption = postTextbox.Text;
            if (postImg.Image != null)
            {
                postDTO.Image = OtherFunction.ImageToByteArray(postImg.Image);
            }
            else postDTO.Image = null;
            //PostBLL.CreatePost(postDTO);
        }

        private void CreatePost_UC_Load(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            Image image;
            using (MemoryStream ms = new MemoryStream(curUser.ImageUS))
            {
                image = Image.FromStream(ms);
                curVolImg.Image = image;
            }
            if (volName == null) volName.Text = curUser.AccountName;
            else volName.Text = curVol.Name;
        }
    }
}
