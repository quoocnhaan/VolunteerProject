using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using VolunProject.UserInterface.Event.OrganizationRegisterFormControl;

namespace VolunProject.UserInterface.Home
{
    public partial class Home_UC : UserControl
    {
        private Panel scrollablePanel;
        private VScrollBar verticalScrollBar;
        public Home_UC()
        {
            InitializeComponent();
            sub();
        }

        private void sub()
        {
            Post_UC.deleteEvent += Post_UC_deleteEvent;
            Post_UC.updateEvent += Post_UC_updateEvent;
        }

        private void Post_UC_updateEvent(object sender, EventArgs e)
        {
            loadPost();
        }

        private void Post_UC_deleteEvent(object sender, EventArgs e)
        {
            loadPost();
        }

        public void loadPost()
        {
            postPanel.Controls.Clear();
            var list = PostBLL.getAllPost();
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1123, 701);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            int x = (postPanel.Width - EventflowLayoutPanel.Width) / 2;
            EventflowLayoutPanel.Location = new System.Drawing.Point(x, EventflowLayoutPanel.Location.Y);
            foreach (var post in list)
            {
                Post_UC post_UC = new Post_UC(post);
                EventflowLayoutPanel.Controls.Add(post_UC);
            }
            postPanel.Controls.Add(EventflowLayoutPanel);
        }
        private void Home_UC_Load(object sender, EventArgs e)
        {
            loadPost();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            var rank = RankingBLL.getRankingByID(curVol.RankId);
            message.Text = "Chào " + curUser.AccountName + ", bạn đã tích lũy được hạng " + rank.RankName;
            Image image, image2;
            using (MemoryStream ms1 = new MemoryStream(rank.RankImage))
            {
                image = Image.FromStream(ms1);
                rankImg.Image = image;
            }
            using (MemoryStream ms2 = new MemoryStream(curUser.ImageUS))
            {
                image2 = Image.FromStream(ms2);
                curVolImg.Image = image2;
            }
            message2.Text = curVol.PrestigeScore + "/" + rank.PointRequire;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            CreatePost_Form createPost_Form = new CreatePost_Form();
            createPost_Form.ShowDialog();
        }
    }
}
