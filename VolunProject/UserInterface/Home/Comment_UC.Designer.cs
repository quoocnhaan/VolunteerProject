namespace VolunProject.UserInterface.Home
{
    partial class Comment_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmtID = new System.Windows.Forms.Label();
            this.cmtTextbox = new System.Windows.Forms.TextBox();
            this.cmtName = new System.Windows.Forms.Label();
            this.commentImg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accountID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmtID);
            this.panel1.Controls.Add(this.cmtTextbox);
            this.panel1.Controls.Add(this.cmtName);
            this.panel1.Controls.Add(this.commentImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 135);
            this.panel1.TabIndex = 0;
            // 
            // accountID
            // 
            this.accountID.AutoSize = true;
            this.accountID.Location = new System.Drawing.Point(372, 35);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(70, 25);
            this.accountID.TabIndex = 5;
            this.accountID.Text = "label1";
            this.accountID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_ellipsis_30;
            this.pictureBox1.Location = new System.Drawing.Point(1181, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmtID
            // 
            this.cmtID.AutoSize = true;
            this.cmtID.Location = new System.Drawing.Point(766, 27);
            this.cmtID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cmtID.Name = "cmtID";
            this.cmtID.Size = new System.Drawing.Size(70, 25);
            this.cmtID.TabIndex = 3;
            this.cmtID.Text = "label1";
            this.cmtID.Visible = false;
            // 
            // cmtTextbox
            // 
            this.cmtTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmtTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmtTextbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtTextbox.Location = new System.Drawing.Point(110, 73);
            this.cmtTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.cmtTextbox.Multiline = true;
            this.cmtTextbox.Name = "cmtTextbox";
            this.cmtTextbox.ReadOnly = true;
            this.cmtTextbox.Size = new System.Drawing.Size(1118, 44);
            this.cmtTextbox.TabIndex = 2;
            this.cmtTextbox.TextChanged += new System.EventHandler(this.cmtTextbox_TextChanged);
            this.cmtTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmtTextbox_KeyDown);
            // 
            // cmtName
            // 
            this.cmtName.AutoSize = true;
            this.cmtName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtName.Location = new System.Drawing.Point(102, 25);
            this.cmtName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cmtName.Name = "cmtName";
            this.cmtName.Size = new System.Drawing.Size(104, 45);
            this.cmtName.TabIndex = 1;
            this.cmtName.Text = "Name";
            // 
            // commentImg
            // 
            //this.commentImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.commentImg.Location = new System.Drawing.Point(6, 25);
            this.commentImg.Margin = new System.Windows.Forms.Padding(6);
            this.commentImg.Name = "commentImg";
            this.commentImg.Size = new System.Drawing.Size(84, 73);
            this.commentImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentImg.TabIndex = 0;
            this.commentImg.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 80);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // Comment_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Comment_UC";
            this.Size = new System.Drawing.Size(1276, 137);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox commentImg;
        private System.Windows.Forms.Label cmtName;
        private System.Windows.Forms.TextBox cmtTextbox;
        private System.Windows.Forms.Label cmtID;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.Label accountID;
    }
}
