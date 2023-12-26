namespace VolunProject.UserInterface.History
{
    partial class History_UC
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
            this.eventHistoryBTN = new System.Windows.Forms.Button();
            this.rewardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventHistoryBTN
            // 
            this.eventHistoryBTN.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventHistoryBTN.Location = new System.Drawing.Point(1939, 160);
            this.eventHistoryBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventHistoryBTN.Name = "eventHistoryBTN";
            this.eventHistoryBTN.Size = new System.Drawing.Size(206, 60);
            this.eventHistoryBTN.TabIndex = 1;
            this.eventHistoryBTN.Text = "Sự kiện";
            this.eventHistoryBTN.UseVisualStyleBackColor = true;
            this.eventHistoryBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // rewardButton
            // 
            this.rewardButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardButton.Location = new System.Drawing.Point(1727, 160);
            this.rewardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rewardButton.Name = "rewardButton";
            this.rewardButton.Size = new System.Drawing.Size(206, 60);
            this.rewardButton.TabIndex = 1;
            this.rewardButton.Text = "Đổi quà";
            this.rewardButton.UseVisualStyleBackColor = true;
            this.rewardButton.Click += new System.EventHandler(this.rewardButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rewardButton);
            this.panel1.Controls.Add(this.eventHistoryBTN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2210, 234);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(720, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử đổi thưởng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 230);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2204, 1104);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // History_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "History_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(2210, 1338);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventHistoryBTN;
        private System.Windows.Forms.Button rewardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
