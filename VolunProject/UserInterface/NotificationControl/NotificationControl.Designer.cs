namespace VolunProject.UserInterface.NotificationControl
{
    partial class NotificationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationControl));
            this.NotiImg = new System.Windows.Forms.PictureBox();
            this.DateTimeLB = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NotiContentTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NotiImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotiImg
            // 
            this.NotiImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NotiImg.Image = global::VolunProject.Properties.Resources.download;
            this.NotiImg.Location = new System.Drawing.Point(24, 17);
            this.NotiImg.Name = "NotiImg";
            this.NotiImg.Size = new System.Drawing.Size(121, 109);
            this.NotiImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotiImg.TabIndex = 32;
            this.NotiImg.TabStop = false;
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.DateTimeLB.Location = new System.Drawing.Point(1198, 88);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(110, 22);
            this.DateTimeLB.TabIndex = 34;
            this.DateTimeLB.Text = "22/07/2002";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VolunProject.Properties.Resources.icons8_calendar_50;
            this.pictureBox3.Location = new System.Drawing.Point(1143, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.TimeLB.Location = new System.Drawing.Point(1198, 31);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(140, 22);
            this.TimeLB.TabIndex = 35;
            this.TimeLB.Text = "15:00 - 16:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VolunProject.Properties.Resources.icons8_clock_50;
            this.pictureBox1.Location = new System.Drawing.Point(1143, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // NotiContentTXT
            // 
            this.NotiContentTXT.BackColor = System.Drawing.Color.White;
            this.NotiContentTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotiContentTXT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiContentTXT.Location = new System.Drawing.Point(161, 17);
            this.NotiContentTXT.Multiline = true;
            this.NotiContentTXT.Name = "NotiContentTXT";
            this.NotiContentTXT.Size = new System.Drawing.Size(942, 109);
            this.NotiContentTXT.TabIndex = 37;
            this.NotiContentTXT.Text = resources.GetString("NotiContentTXT.Text");
            // 
            // NotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NotiContentTXT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.DateTimeLB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.NotiImg);
            this.Name = "NotificationControl";
            this.Size = new System.Drawing.Size(1400, 140);
            ((System.ComponentModel.ISupportInitialize)(this.NotiImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox NotiImg;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NotiContentTXT;
    }
}
