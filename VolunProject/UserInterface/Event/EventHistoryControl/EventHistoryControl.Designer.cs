namespace VolunProject.UserInterface.Event.EventHistoryControl
{
    partial class EventHistoryControl
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
            this.TimeLB = new System.Windows.Forms.Label();
            this.DateTimeLB = new System.Windows.Forms.Label();
            this.DetailEventBtn = new System.Windows.Forms.Button();
            this.addressLB = new System.Windows.Forms.Label();
            this.eventTitle = new System.Windows.Forms.Label();
            this.RegisterDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EventImageBox = new System.Windows.Forms.PictureBox();
            this.CancelEventBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.TimeLB.Location = new System.Drawing.Point(303, 148);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(140, 22);
            this.TimeLB.TabIndex = 35;
            this.TimeLB.Text = "15:00 - 16:00";
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.DateTimeLB.Location = new System.Drawing.Point(303, 88);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(230, 22);
            this.DateTimeLB.TabIndex = 34;
            this.DateTimeLB.Text = "22/07/2002 - 20/1/2023";
            // 
            // DetailEventBtn
            // 
            this.DetailEventBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DetailEventBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailEventBtn.Location = new System.Drawing.Point(977, 76);
            this.DetailEventBtn.Name = "DetailEventBtn";
            this.DetailEventBtn.Size = new System.Drawing.Size(139, 49);
            this.DetailEventBtn.TabIndex = 31;
            this.DetailEventBtn.Text = "Chi tiết";
            this.DetailEventBtn.UseVisualStyleBackColor = false;
            this.DetailEventBtn.Click += new System.EventHandler(this.DetailEventBtn_Click);
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLB.Location = new System.Drawing.Point(244, 53);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(531, 19);
            this.addressLB.TabIndex = 29;
            this.addressLB.Text = "634/2323/23 Mã Lò, Bình trị đông A , quận bình tân, TP HCM";
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitle.Location = new System.Drawing.Point(244, 16);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(166, 24);
            this.eventTitle.TabIndex = 28;
            this.eventTitle.Text = "Sự kiện gì đó";
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSize = true;
            this.RegisterDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterDate.Location = new System.Drawing.Point(1184, 21);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(99, 19);
            this.RegisterDate.TabIndex = 38;
            this.RegisterDate.Text = "22/07/2002";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1052, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ngày đăng ký:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VolunProject.Properties.Resources.icons8_clock_50;
            this.pictureBox1.Location = new System.Drawing.Point(248, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VolunProject.Properties.Resources.icons8_calendar_50;
            this.pictureBox3.Location = new System.Drawing.Point(248, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // EventImageBox
            // 
            this.EventImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EventImageBox.Image = global::VolunProject.Properties.Resources.download;
            this.EventImageBox.Location = new System.Drawing.Point(22, 16);
            this.EventImageBox.Name = "EventImageBox";
            this.EventImageBox.Size = new System.Drawing.Size(202, 165);
            this.EventImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventImageBox.TabIndex = 32;
            this.EventImageBox.TabStop = false;
            // 
            // CancelEventBTN
            // 
            this.CancelEventBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelEventBTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelEventBTN.Image = global::VolunProject.Properties.Resources.icons8_cancel_48;
            this.CancelEventBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelEventBTN.Location = new System.Drawing.Point(1142, 75);
            this.CancelEventBTN.Name = "CancelEventBTN";
            this.CancelEventBTN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CancelEventBTN.Size = new System.Drawing.Size(212, 50);
            this.CancelEventBTN.TabIndex = 30;
            this.CancelEventBTN.Text = "  Hủy đăng ký";
            this.CancelEventBTN.UseVisualStyleBackColor = false;
            this.CancelEventBTN.Click += new System.EventHandler(this.JoinEventBtn_Click);
            // 
            // EventHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.DateTimeLB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EventImageBox);
            this.Controls.Add(this.DetailEventBtn);
            this.Controls.Add(this.CancelEventBTN);
            this.Controls.Add(this.addressLB);
            this.Controls.Add(this.eventTitle);
            this.Name = "EventHistoryControl";
            this.Size = new System.Drawing.Size(1400, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox EventImageBox;
        private System.Windows.Forms.Button DetailEventBtn;
        private System.Windows.Forms.Button CancelEventBTN;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.Label RegisterDate;
        private System.Windows.Forms.Label label1;
    }
}
