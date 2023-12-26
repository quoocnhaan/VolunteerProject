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

namespace VolunProject.UserInterface.Home
{
    public partial class Comment_UC : UserControl
    {
        public static event EventHandler deleteEvent;
        public static event EventHandler updateEvent;
        public Comment_UC(byte[] img, CommentDTO commentDTO, string name, string ID)
        {
            InitializeComponent();
            Image image;
            using (MemoryStream ms = new MemoryStream(img))
            {
                image = Image.FromStream(ms);
                commentImg.Image = image;
            }
            cmtTextbox.Text = commentDTO.CommentContent;
            cmtID.Text = commentDTO.CommentID;
            cmtName.Text = name;
            accountID.Text = ID;
        }

        private void cmtTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = cmtTextbox.Text.Length;
            if (charCount <= 69)
            {
                cmtTextbox.Height = 26;
                panel1.Height = 70;
                this.Height = 70;
            }
            else
            {
                int line = charCount / 69;
                cmtTextbox.Height = 22 * (line + 1);
                panel1.Height = 70 + 22 * line;
                this.Height = 70 + 22 * line;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CommentBLL.deleteComment(cmtID.Text))
            {
                deleteEvent(this, new EventArgs());
            }
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cmtTextbox.BorderStyle = BorderStyle.FixedSingle;
            this.cmtTextbox.ReadOnly = false;
            this.cmtTextbox.Focus();
        }

        private void cmtTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmtTextbox.Text.Length > 0)
            {
                string enteredText = cmtTextbox.Text;
                
                if (CommentBLL.updateComment(cmtID.Text,enteredText))
                {
                    this.cmtTextbox.BorderStyle = BorderStyle.None;
                    this.cmtTextbox.ReadOnly = true;
                    
                    updateEvent(this, new EventArgs());
                }              
            }
            if(e.KeyCode == Keys.Enter && cmtTextbox.Text.Length == 0)
            {
                if (CommentBLL.deleteComment(cmtID.Text))
                {
                    deleteEvent(this, new EventArgs());                
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.cmtTextbox.BorderStyle = BorderStyle.None;
                this.cmtTextbox.ReadOnly = true;
            }
            //e.SuppressKeyPress = true;
        }
    }
}
