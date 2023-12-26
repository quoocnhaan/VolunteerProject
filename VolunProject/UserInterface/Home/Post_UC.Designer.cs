namespace VolunProject.UserInterface.Home
{
    partial class Post_UC
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.postID = new System.Windows.Forms.Label();
            this.captionTextbox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.volImg = new System.Windows.Forms.PictureBox();
            this.volName = new System.Windows.Forms.Label();
            this.cmtLabel = new System.Windows.Forms.Label();
            this.likeLabel = new System.Windows.Forms.Label();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.cmtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cmtImg = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.postImg = new System.Windows.Forms.PictureBox();
            this.likePanel = new System.Windows.Forms.Panel();
            this.likeButton = new System.Windows.Forms.Button();
            this.cmtPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volImg)).BeginInit();
            this.cmtFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmtImg)).BeginInit();
            this.imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).BeginInit();
            this.likePanel.SuspendLayout();
            this.cmtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentPanel.Controls.Add(this.pictureBox2);
            this.contentPanel.Controls.Add(this.postID);
            this.contentPanel.Controls.Add(this.captionTextbox);
            this.contentPanel.Controls.Add(this.time);
            this.contentPanel.Controls.Add(this.volImg);
            this.contentPanel.Controls.Add(this.volName);
            this.contentPanel.Location = new System.Drawing.Point(12, 17);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(6);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1410, 225);
            this.contentPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VolunProject.Properties.Resources.icons8_ellipsis_30;
            this.pictureBox2.Location = new System.Drawing.Point(1340, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // postID
            // 
            this.postID.AutoSize = true;
            this.postID.Location = new System.Drawing.Point(1085, 44);
            this.postID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.postID.Name = "postID";
            this.postID.Size = new System.Drawing.Size(70, 25);
            this.postID.TabIndex = 12;
            this.postID.Text = "label1";
            this.postID.Visible = false;
            // 
            // captionTextbox
            // 
            this.captionTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.captionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captionTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionTextbox.Location = new System.Drawing.Point(8, 162);
            this.captionTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.captionTextbox.Multiline = true;
            this.captionTextbox.Name = "captionTextbox";
            this.captionTextbox.ReadOnly = true;
            this.captionTextbox.Size = new System.Drawing.Size(1394, 46);
            this.captionTextbox.TabIndex = 3;
            this.captionTextbox.TextChanged += new System.EventHandler(this.captionTextbox_TextChanged);
            this.captionTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.captionTextbox_KeyDown);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(160, 87);
            this.time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(89, 37);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            // 
            // volImg
            // 
            //this.volImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.volImg.Location = new System.Drawing.Point(6, 27);
            this.volImg.Margin = new System.Windows.Forms.Padding(6);
            this.volImg.Name = "volImg";
            this.volImg.Size = new System.Drawing.Size(142, 123);
            this.volImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volImg.TabIndex = 1;
            this.volImg.TabStop = false;
            // 
            // volName
            // 
            this.volName.AutoSize = true;
            this.volName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volName.Location = new System.Drawing.Point(160, 44);
            this.volName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.volName.Name = "volName";
            this.volName.Size = new System.Drawing.Size(83, 45);
            this.volName.TabIndex = 0;
            this.volName.Text = "Tên";
            // 
            // cmtLabel
            // 
            this.cmtLabel.AutoSize = true;
            this.cmtLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtLabel.Location = new System.Drawing.Point(88, 19);
            this.cmtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cmtLabel.Name = "cmtLabel";
            this.cmtLabel.Size = new System.Drawing.Size(91, 50);
            this.cmtLabel.TabIndex = 9;
            this.cmtLabel.Text = "cmt";
            // 
            // likeLabel
            // 
            this.likeLabel.AutoSize = true;
            this.likeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.ForeColor = System.Drawing.Color.Red;
            this.likeLabel.Location = new System.Drawing.Point(70, 15);
            this.likeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(137, 50);
            this.likeLabel.TabIndex = 6;
            this.likeLabel.Text = "Likes";
            this.likeLabel.Click += new System.EventHandler(this.likeLabel_Click);
            // 
            // commentTextbox
            // 
            this.commentTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextbox.Location = new System.Drawing.Point(86, 6);
            this.commentTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.Size = new System.Drawing.Size(1310, 46);
            this.commentTextbox.TabIndex = 7;
            this.commentTextbox.TextChanged += new System.EventHandler(this.commentTextbox_TextChanged);
            this.commentTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commentTextbox_KeyDown);
            // 
            // cmtFlowLayout
            // 
            this.cmtFlowLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmtFlowLayout.Controls.Add(this.cmtImg);
            this.cmtFlowLayout.Controls.Add(this.commentTextbox);
            this.cmtFlowLayout.Controls.Add(this.flowLayoutPanel1);
            this.cmtFlowLayout.Location = new System.Drawing.Point(10, 458);
            this.cmtFlowLayout.Margin = new System.Windows.Forms.Padding(6);
            this.cmtFlowLayout.Name = "cmtFlowLayout";
            this.cmtFlowLayout.Size = new System.Drawing.Size(1412, 460);
            this.cmtFlowLayout.TabIndex = 1;
            // 
            // cmtImg
            // 
            //this.cmtImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.cmtImg.Location = new System.Drawing.Point(6, 6);
            this.cmtImg.Margin = new System.Windows.Forms.Padding(6);
            this.cmtImg.Name = "cmtImg";
            this.cmtImg.Size = new System.Drawing.Size(68, 50);
            this.cmtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmtImg.TabIndex = 8;
            this.cmtImg.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1394, 392);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgPanel.Controls.Add(this.postImg);
            this.imgPanel.Controls.Add(this.likePanel);
            this.imgPanel.Controls.Add(this.cmtPanel);
            this.imgPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPanel.Location = new System.Drawing.Point(12, 254);
            this.imgPanel.Margin = new System.Windows.Forms.Padding(6);
            this.imgPanel.MinimumSize = new System.Drawing.Size(1406, 192);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(1410, 192);
            this.imgPanel.TabIndex = 11;
            // 
            // postImg
            // 
            this.postImg.Image = global::VolunProject.Properties.Resources.download;
            this.postImg.Location = new System.Drawing.Point(6, 6);
            this.postImg.Margin = new System.Windows.Forms.Padding(6);
            this.postImg.MaximumSize = new System.Drawing.Size(1406, 1154);
            this.postImg.Name = "postImg";
            this.postImg.Size = new System.Drawing.Size(62, 54);
            this.postImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postImg.TabIndex = 3;
            this.postImg.TabStop = false;
            this.postImg.Visible = false;
            // 
            // likePanel
            // 
            this.likePanel.Controls.Add(this.likeButton);
            this.likePanel.Controls.Add(this.likeLabel);
            this.likePanel.Location = new System.Drawing.Point(6, 63);
            this.likePanel.Margin = new System.Windows.Forms.Padding(6);
            this.likePanel.Name = "likePanel";
            this.likePanel.Size = new System.Drawing.Size(258, 96);
            this.likePanel.TabIndex = 9;
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeButton.Image = global::VolunProject.Properties.Resources.icons8_heart_24;
            this.likeButton.Location = new System.Drawing.Point(10, 15);
            this.likeButton.Margin = new System.Windows.Forms.Padding(6);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(56, 58);
            this.likeButton.TabIndex = 5;
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // cmtPanel
            // 
            this.cmtPanel.Controls.Add(this.cmtLabel);
            this.cmtPanel.Controls.Add(this.pictureBox1);
            this.cmtPanel.Location = new System.Drawing.Point(614, 62);
            this.cmtPanel.Margin = new System.Windows.Forms.Padding(6);
            this.cmtPanel.Name = "cmtPanel";
            this.cmtPanel.Size = new System.Drawing.Size(232, 92);
            this.cmtPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_comment_24;
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // Post_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.cmtFlowLayout);
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 38, 6, 38);
            this.Name = "Post_UC";
            this.Size = new System.Drawing.Size(1440, 927);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volImg)).EndInit();
            this.cmtFlowLayout.ResumeLayout(false);
            this.cmtFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmtImg)).EndInit();
            this.imgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).EndInit();
            this.likePanel.ResumeLayout(false);
            this.likePanel.PerformLayout();
            this.cmtPanel.ResumeLayout(false);
            this.cmtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox volImg;
        private System.Windows.Forms.Label volName;
        private System.Windows.Forms.FlowLayoutPanel cmtFlowLayout;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox postImg;
        private System.Windows.Forms.Label likeLabel;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.Label cmtLabel;
        private System.Windows.Forms.PictureBox cmtImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captionTextbox;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Label postID;
        private System.Windows.Forms.Panel likePanel;
        private System.Windows.Forms.Panel cmtPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
    }
}
