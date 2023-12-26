using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using static System.Windows.Forms.LinkLabel;

namespace VolunProject.UserInterface.Home
{
    public partial class CreatePost_Form : Form
    {
        public static event EventHandler LoadEvent;
        private bool isChange = false;

        public CreatePost_Form()
        {
            InitializeComponent();
        }
        private void postTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = postTextbox.Text.Length;
            if (charCount <= 71)
            {
                postTextbox.Height = 24;
                panel2.Location = new Point(24, 128);
                this.Height = 639;
                panel1.Height = 639;
            }
            else
            {
                int line = charCount / 71;
                postTextbox.Height = 24 * (line + 1);
                panel2.Location = new Point(24, 128 + (line * 22));
                this.Height = 639 + 24 * line;
                panel1.Height = 639 + 24 * line;
            }
        }

        private void CreatePost_Form_Load(object sender, EventArgs e)
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

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;

                    postImg.Image = Image.FromFile(selectedFileName);
                    postImg.SizeMode = PictureBoxSizeMode.Zoom;
                    isChange = true;
                    string filePath = selectedFileName;
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            PostDTO postDTO = new PostDTO();
            postDTO.Caption = postTextbox.Text;
            postDTO.Image = OtherFunction.ImageToByteArray(postImg.Image);
            if (PostBLL.CreatePost(postDTO, isChange))
            {
                LoadEvent(this, new EventArgs());
                this.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
