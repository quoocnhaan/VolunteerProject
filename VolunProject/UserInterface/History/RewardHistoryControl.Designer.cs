namespace VolunProject.UserInterface.History
{
    partial class RewardHistoryControl
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
            this.rewardImg = new System.Windows.Forms.PictureBox();
            this.rewardName = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rewardImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rewardImg
            // 
            this.rewardImg.Image = global::VolunProject.Properties.Resources.icons8_gift_50;
            this.rewardImg.Location = new System.Drawing.Point(48, 30);
            this.rewardImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rewardImg.Name = "rewardImg";
            this.rewardImg.Size = new System.Drawing.Size(305, 273);
            this.rewardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rewardImg.TabIndex = 0;
            this.rewardImg.TabStop = false;
            // 
            // rewardName
            // 
            this.rewardName.AutoSize = true;
            this.rewardName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardName.Location = new System.Drawing.Point(379, 30);
            this.rewardName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(98, 42);
            this.rewardName.TabIndex = 0;
            this.rewardName.Text = "Name";
            this.rewardName.Click += new System.EventHandler(this.rewardName_Click);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.Color.Gold;
            this.point.Location = new System.Drawing.Point(505, 143);
            this.point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(135, 48);
            this.point.TabIndex = 0;
            this.point.Text = "Point";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(379, 252);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 42);
            this.date.TabIndex = 0;
            this.date.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.rewardImg);
            this.panel1.Controls.Add(this.rewardName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2133, 327);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm:";
            // 
            // RewardHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(50, 20, 4, 100);
            this.Name = "RewardHistoryControl";
            this.Size = new System.Drawing.Size(1958, 324);
            ((System.ComponentModel.ISupportInitialize)(this.rewardImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rewardImg;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label rewardName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
