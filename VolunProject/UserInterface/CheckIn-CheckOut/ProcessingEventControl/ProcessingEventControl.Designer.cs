namespace VolunProject.UserInterface.CheckIn_CheckOut.ProcessingEventControl
{
    partial class ProcessingEventControl
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
            this.AttendanceBTN = new System.Windows.Forms.Button();
            this.addressLB = new System.Windows.Forms.Label();
            this.eventTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EventImageBox = new System.Windows.Forms.PictureBox();
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
            this.TimeLB.Location = new System.Drawing.Point(315, 150);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(140, 22);
            this.TimeLB.TabIndex = 48;
            this.TimeLB.Text = "15:00 - 16:00";
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLB.ForeColor = System.Drawing.Color.IndianRed;
            this.DateTimeLB.Location = new System.Drawing.Point(315, 90);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(230, 22);
            this.DateTimeLB.TabIndex = 47;
            this.DateTimeLB.Text = "22/07/2002 - 20/1/2023";
            // 
            // AttendanceBTN
            // 
            this.AttendanceBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AttendanceBTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceBTN.Location = new System.Drawing.Point(1117, 77);
            this.AttendanceBTN.Name = "AttendanceBTN";
            this.AttendanceBTN.Size = new System.Drawing.Size(227, 49);
            this.AttendanceBTN.TabIndex = 44;
            this.AttendanceBTN.Text = "Điểm danh";
            this.AttendanceBTN.UseVisualStyleBackColor = false;
            this.AttendanceBTN.Click += new System.EventHandler(this.AttendanceBTN_Click);
            // 
            // addressLB
            // 
            this.addressLB.AutoSize = true;
            this.addressLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLB.Location = new System.Drawing.Point(256, 55);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(531, 19);
            this.addressLB.TabIndex = 42;
            this.addressLB.Text = "634/2323/23 Mã Lò, Bình trị đông A , quận bình tân, TP HCM";
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.eventTitle.Location = new System.Drawing.Point(256, 18);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(166, 24);
            this.eventTitle.TabIndex = 41;
            this.eventTitle.Text = "Sự kiện gì đó";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VolunProject.Properties.Resources.icons8_clock_50;
            this.pictureBox1.Location = new System.Drawing.Point(260, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VolunProject.Properties.Resources.icons8_calendar_50;
            this.pictureBox3.Location = new System.Drawing.Point(260, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // EventImageBox
            // 
            this.EventImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EventImageBox.Image = global::VolunProject.Properties.Resources.download;
            this.EventImageBox.Location = new System.Drawing.Point(34, 18);
            this.EventImageBox.Name = "EventImageBox";
            this.EventImageBox.Size = new System.Drawing.Size(202, 165);
            this.EventImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventImageBox.TabIndex = 45;
            this.EventImageBox.TabStop = false;
            // 
            // ProcessingEventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.DateTimeLB);
            this.Controls.Add(this.AttendanceBTN);
            this.Controls.Add(this.addressLB);
            this.Controls.Add(this.eventTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EventImageBox);
            this.Name = "ProcessingEventControl";
            this.Size = new System.Drawing.Size(1400, 197);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.Button AttendanceBTN;
        private System.Windows.Forms.Label addressLB;
        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox EventImageBox;
    }
}
