namespace VolunProject.UserInterface.Event.EventControl
{
    partial class EventControl
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
            this.eventTitle = new System.Windows.Forms.Label();
            this.addressLB = new System.Windows.Forms.Label();
            this.JoinEventBtn = new System.Windows.Forms.Button();
            this.DetailEventBtn = new System.Windows.Forms.Button();
            this.DateTimeLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.Like = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EventImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitle.Location = new System.Drawing.Point(311, 22);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(166, 24);
            this.eventTitle.TabIndex = 0;
            this.eventTitle.Text = "Sự kiện gì đó";
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLB.Location = new System.Drawing.Point(252, 59);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(531, 19);
            this.addressLB.TabIndex = 2;
            this.addressLB.Text = "634/2323/23 Mã Lò, Bình trị đông A , quận bình tân, TP HCM";
            // 
            // JoinEventBtn
            // 
            this.JoinEventBtn.BackColor = System.Drawing.Color.Bisque;
            this.JoinEventBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinEventBtn.Location = new System.Drawing.Point(1168, 84);
            this.JoinEventBtn.Name = "JoinEventBtn";
            this.JoinEventBtn.Size = new System.Drawing.Size(141, 32);
            this.JoinEventBtn.TabIndex = 3;
            this.JoinEventBtn.Text = "Tham gia";
            this.JoinEventBtn.UseVisualStyleBackColor = false;
            this.JoinEventBtn.Click += new System.EventHandler(this.JoinEventBtn_Click);
            // 
            // DetailEventBtn
            // 
            this.DetailEventBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DetailEventBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailEventBtn.Location = new System.Drawing.Point(1025, 84);
            this.DetailEventBtn.Name = "DetailEventBtn";
            this.DetailEventBtn.Size = new System.Drawing.Size(112, 32);
            this.DetailEventBtn.TabIndex = 5;
            this.DetailEventBtn.Text = "Chi tiết";
            this.DetailEventBtn.UseVisualStyleBackColor = false;
            this.DetailEventBtn.Click += new System.EventHandler(this.DetailEventBtn_Click);
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.DateTimeLB.Location = new System.Drawing.Point(311, 94);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(230, 22);
            this.DateTimeLB.TabIndex = 10;
            this.DateTimeLB.Text = "22/07/2002 - 20/1/2023";
            this.DateTimeLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.TimeLB.Location = new System.Drawing.Point(311, 154);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(140, 22);
            this.TimeLB.TabIndex = 11;
            this.TimeLB.Text = "15:00 - 16:00";
            // 
            // Like
            // 
            this.Like.FlatAppearance.BorderSize = 0;
            this.Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Like.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Like.Image = global::VolunProject.Properties.Resources.icons8_love_401;
            this.Like.Location = new System.Drawing.Point(260, 19);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(45, 35);
            this.Like.TabIndex = 27;
            this.Like.Text = "12";
            this.Like.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VolunProject.Properties.Resources.icons8_clock_50;
            this.pictureBox1.Location = new System.Drawing.Point(256, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VolunProject.Properties.Resources.icons8_calendar_50;
            this.pictureBox3.Location = new System.Drawing.Point(256, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // EventImageBox
            // 
            this.EventImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EventImageBox.Image = global::VolunProject.Properties.Resources.download;
            this.EventImageBox.Location = new System.Drawing.Point(19, 22);
            this.EventImageBox.Name = "EventImageBox";
            this.EventImageBox.Size = new System.Drawing.Size(195, 154);
            this.EventImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventImageBox.TabIndex = 6;
            this.EventImageBox.TabStop = false;
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Like);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.DateTimeLB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EventImageBox);
            this.Controls.Add(this.DetailEventBtn);
            this.Controls.Add(this.JoinEventBtn);
            this.Controls.Add(this.addressLB);
            this.Controls.Add(this.eventTitle);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(1400, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.Button JoinEventBtn;
        private System.Windows.Forms.Button DetailEventBtn;
        private System.Windows.Forms.PictureBox EventImageBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Like;
    }
}
