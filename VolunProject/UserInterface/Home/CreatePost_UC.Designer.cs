namespace VolunProject.UserInterface.Home
{
    partial class CreatePost_UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.postTextbox = new System.Windows.Forms.TextBox();
            this.volName = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.curVolImg = new System.Windows.Forms.PictureBox();
            this.postImg = new System.Windows.Forms.PictureBox();
            this.postButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curVolImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Controls.Add(this.volName);
            this.panel1.Controls.Add(this.postTextbox);
            this.panel1.Controls.Add(this.curVolImg);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 219);
            this.panel1.TabIndex = 0;
            // 
            // postTextbox
            // 
            this.postTextbox.Location = new System.Drawing.Point(24, 93);
            this.postTextbox.Multiline = true;
            this.postTextbox.Name = "postTextbox";
            this.postTextbox.Size = new System.Drawing.Size(658, 24);
            this.postTextbox.TabIndex = 1;
            this.postTextbox.TextChanged += new System.EventHandler(this.postTextbox_TextChanged);
            // 
            // volName
            // 
            this.volName.AutoSize = true;
            this.volName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volName.Location = new System.Drawing.Point(121, 35);
            this.volName.Name = "volName";
            this.volName.Size = new System.Drawing.Size(59, 32);
            this.volName.TabIndex = 2;
            this.volName.Text = "Tên";
            // 
            // uploadButton
            // 
            this.uploadButton.Image = global::VolunProject.Properties.Resources.icons8_upload_100;
            this.uploadButton.Location = new System.Drawing.Point(688, 93);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(34, 24);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // curVolImg
            // 
            //this.curVolImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.curVolImg.Location = new System.Drawing.Point(24, 12);
            this.curVolImg.Name = "curVolImg";
            this.curVolImg.Size = new System.Drawing.Size(76, 75);
            this.curVolImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curVolImg.TabIndex = 0;
            this.curVolImg.TabStop = false;
            // 
            // postImg
            // 
            this.postImg.Image = global::VolunProject.Properties.Resources.icons8_volunteer_64;
            this.postImg.Location = new System.Drawing.Point(293, 2);
            this.postImg.Name = "postImg";
            this.postImg.Size = new System.Drawing.Size(28, 25);
            this.postImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postImg.TabIndex = 4;
            this.postImg.TabStop = false;
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.postButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postButton.Location = new System.Drawing.Point(3, 38);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(97, 33);
            this.postButton.TabIndex = 5;
            this.postButton.Text = "Đăng bài";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(106, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 33);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Hủy";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.postButton);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.postImg);
            this.panel2.Location = new System.Drawing.Point(24, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 74);
            this.panel2.TabIndex = 6;
            // 
            // CreatePost_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreatePost_UC";
            this.Size = new System.Drawing.Size(756, 227);
            this.Load += new System.EventHandler(this.CreatePost_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curVolImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox curVolImg;
        private System.Windows.Forms.TextBox postTextbox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label volName;
        private System.Windows.Forms.PictureBox postImg;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Panel panel2;
    }
}
