namespace VolunProject
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createReward = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NotificationBTN = new System.Windows.Forms.Button();
            this.signOutButoon = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.rewardsButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel3);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(274, 879);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(101, 879);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(274, 879);
            this.sidebarContainer.TabIndex = 0;
            this.sidebarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(236, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 776);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 69);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NotificationBTN);
            this.panel3.Controls.Add(this.createReward);
            this.panel3.Controls.Add(this.signOutButoon);
            this.panel3.Controls.Add(this.infoButton);
            this.panel3.Controls.Add(this.historyButton);
            this.panel3.Controls.Add(this.rewardsButton);
            this.panel3.Controls.Add(this.eventButton);
            this.panel3.Controls.Add(this.homeButton);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 770);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // createReward
            // 
            this.createReward.Dock = System.Windows.Forms.DockStyle.Top;
            this.createReward.FlatAppearance.BorderSize = 0;
            this.createReward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReward.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createReward.Location = new System.Drawing.Point(0, 235);
            this.createReward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createReward.Name = "createReward";
            this.createReward.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.createReward.Size = new System.Drawing.Size(271, 47);
            this.createReward.TabIndex = 6;
            this.createReward.Text = "                  Tạo quà";
            this.createReward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createReward.UseVisualStyleBackColor = true;
            this.createReward.Visible = false;
            this.createReward.Click += new System.EventHandler(this.createReward_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MainPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(274, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1472, 879);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(3, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MainPanel.Size = new System.Drawing.Size(1468, 879);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::VolunProject.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // NotificationBTN
            // 
            this.NotificationBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationBTN.FlatAppearance.BorderSize = 0;
            this.NotificationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NotificationBTN.Image = global::VolunProject.Properties.Resources.icons8_notification_24__1_;
            this.NotificationBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationBTN.Location = new System.Drawing.Point(0, 282);
            this.NotificationBTN.Name = "NotificationBTN";
            this.NotificationBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NotificationBTN.Size = new System.Drawing.Size(271, 47);
            this.NotificationBTN.TabIndex = 6;
            this.NotificationBTN.Text = "                  Thông báo";
            this.NotificationBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationBTN.UseVisualStyleBackColor = true;
            this.NotificationBTN.Click += new System.EventHandler(this.NotificationBTN_Click);
            // 
            // signOutButoon
            // 
            this.signOutButoon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.signOutButoon.FlatAppearance.BorderSize = 0;
            this.signOutButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButoon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signOutButoon.Image = global::VolunProject.Properties.Resources.icons8_log_out_24;
            this.signOutButoon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutButoon.Location = new System.Drawing.Point(0, 723);
            this.signOutButoon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signOutButoon.Name = "signOutButoon";
            this.signOutButoon.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.signOutButoon.Size = new System.Drawing.Size(271, 47);
            this.signOutButoon.TabIndex = 5;
            this.signOutButoon.Text = "                  Đăng xuất";
            this.signOutButoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutButoon.UseVisualStyleBackColor = true;
            this.signOutButoon.Click += new System.EventHandler(this.signOutButoon_Click);
            // 
            // infoButton
            // 
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoButton.Image = global::VolunProject.Properties.Resources.icons8_user_24__1_;
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.Location = new System.Drawing.Point(0, 188);
            this.infoButton.Name = "infoButton";
            this.infoButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.infoButton.Size = new System.Drawing.Size(271, 47);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "                  Thông tin";
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historyButton.Image = global::VolunProject.Properties.Resources.icons8_history_24;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.Location = new System.Drawing.Point(0, 141);
            this.historyButton.Name = "historyButton";
            this.historyButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.historyButton.Size = new System.Drawing.Size(271, 47);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "                  Lịch sử";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // rewardsButton
            // 
            this.rewardsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rewardsButton.FlatAppearance.BorderSize = 0;
            this.rewardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewardsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rewardsButton.Image = global::VolunProject.Properties.Resources.icons8_reward_24;
            this.rewardsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rewardsButton.Location = new System.Drawing.Point(0, 94);
            this.rewardsButton.Name = "rewardsButton";
            this.rewardsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rewardsButton.Size = new System.Drawing.Size(271, 47);
            this.rewardsButton.TabIndex = 3;
            this.rewardsButton.Text = "                  Đổi thưởng";
            this.rewardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rewardsButton.UseVisualStyleBackColor = true;
            this.rewardsButton.Click += new System.EventHandler(this.rewardsButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventButton.FlatAppearance.BorderSize = 0;
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventButton.Image = global::VolunProject.Properties.Resources.event2;
            this.eventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.Location = new System.Drawing.Point(0, 47);
            this.eventButton.Name = "eventButton";
            this.eventButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eventButton.Size = new System.Drawing.Size(271, 47);
            this.eventButton.TabIndex = 2;
            this.eventButton.Text = "                  Sự kiện";
            this.eventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.Image = global::VolunProject.Properties.Resources.icons8_home_24;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(271, 47);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "                  Trang chính";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1746, 879);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button rewardsButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button signOutButoon;
        private System.Windows.Forms.Button createReward;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button NotificationBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

