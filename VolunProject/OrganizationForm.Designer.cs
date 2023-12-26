namespace VolunProject
{
    partial class OrganizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationForm));
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiemDanhBTN = new System.Windows.Forms.Button();
            this.notifyBTN = new System.Windows.Forms.Button();
            this.SignOutBTN = new System.Windows.Forms.Button();
            this.CreateEventButoon = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.ApproveVolunteerBTN = new System.Windows.Forms.Button();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.sidebarContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 69);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DiemDanhBTN);
            this.panel3.Controls.Add(this.notifyBTN);
            this.panel3.Controls.Add(this.SignOutBTN);
            this.panel3.Controls.Add(this.CreateEventButoon);
            this.panel3.Controls.Add(this.eventButton);
            this.panel3.Controls.Add(this.ApproveVolunteerBTN);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 770);
            this.panel3.TabIndex = 2;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Location = new System.Drawing.Point(277, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1519, 879);
            this.MainPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_menu_501;
            this.pictureBox1.Location = new System.Drawing.Point(29, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DiemDanhBTN
            // 
            this.DiemDanhBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiemDanhBTN.FlatAppearance.BorderSize = 0;
            this.DiemDanhBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiemDanhBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemDanhBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiemDanhBTN.Image = global::VolunProject.Properties.Resources.icons8_attendance_48;
            this.DiemDanhBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiemDanhBTN.Location = new System.Drawing.Point(0, 280);
            this.DiemDanhBTN.Name = "DiemDanhBTN";
            this.DiemDanhBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DiemDanhBTN.Size = new System.Drawing.Size(271, 70);
            this.DiemDanhBTN.TabIndex = 8;
            this.DiemDanhBTN.Text = "                   Điểm danh ";
            this.DiemDanhBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiemDanhBTN.UseVisualStyleBackColor = true;
            this.DiemDanhBTN.Click += new System.EventHandler(this.DiemDanhBTN_Click);
            // 
            // notifyBTN
            // 
            this.notifyBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifyBTN.FlatAppearance.BorderSize = 0;
            this.notifyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notifyBTN.Image = global::VolunProject.Properties.Resources.icons8_notification_501;
            this.notifyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notifyBTN.Location = new System.Drawing.Point(0, 210);
            this.notifyBTN.Name = "notifyBTN";
            this.notifyBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.notifyBTN.Size = new System.Drawing.Size(271, 70);
            this.notifyBTN.TabIndex = 7;
            this.notifyBTN.Text = "                  Thông báo";
            this.notifyBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notifyBTN.UseVisualStyleBackColor = true;
            this.notifyBTN.Click += new System.EventHandler(this.notifyBTN_Click);
            // 
            // SignOutBTN
            // 
            this.SignOutBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignOutBTN.FlatAppearance.BorderSize = 0;
            this.SignOutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignOutBTN.Image = global::VolunProject.Properties.Resources.icons8_log_out_50;
            this.SignOutBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutBTN.Location = new System.Drawing.Point(0, 700);
            this.SignOutBTN.Name = "SignOutBTN";
            this.SignOutBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SignOutBTN.Size = new System.Drawing.Size(271, 70);
            this.SignOutBTN.TabIndex = 6;
            this.SignOutBTN.Text = "                  Đăng xuất";
            this.SignOutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutBTN.UseVisualStyleBackColor = true;
            this.SignOutBTN.Click += new System.EventHandler(this.SignOutBTN_Click);
            // 
            // CreateEventButoon
            // 
            this.CreateEventButoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateEventButoon.FlatAppearance.BorderSize = 0;
            this.CreateEventButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEventButoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEventButoon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateEventButoon.Image = global::VolunProject.Properties.Resources.icons8_add_list_50;
            this.CreateEventButoon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateEventButoon.Location = new System.Drawing.Point(0, 140);
            this.CreateEventButoon.Name = "CreateEventButoon";
            this.CreateEventButoon.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CreateEventButoon.Size = new System.Drawing.Size(271, 70);
            this.CreateEventButoon.TabIndex = 5;
            this.CreateEventButoon.Text = "                  Tạo sự kiện";
            this.CreateEventButoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateEventButoon.UseVisualStyleBackColor = true;
            this.CreateEventButoon.Click += new System.EventHandler(this.CreateEventButoon_Click);
            // 
            // eventButton
            // 
            this.eventButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventButton.FlatAppearance.BorderSize = 0;
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventButton.Image = global::VolunProject.Properties.Resources.icons8_event_501;
            this.eventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.Location = new System.Drawing.Point(0, 70);
            this.eventButton.Name = "eventButton";
            this.eventButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eventButton.Size = new System.Drawing.Size(271, 70);
            this.eventButton.TabIndex = 1;
            this.eventButton.Text = "                  Sự kiện";
            this.eventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // ApproveVolunteerBTN
            // 
            this.ApproveVolunteerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApproveVolunteerBTN.FlatAppearance.BorderSize = 0;
            this.ApproveVolunteerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveVolunteerBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveVolunteerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApproveVolunteerBTN.Image = global::VolunProject.Properties.Resources.icons8_approve_50;
            this.ApproveVolunteerBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApproveVolunteerBTN.Location = new System.Drawing.Point(0, 0);
            this.ApproveVolunteerBTN.Margin = new System.Windows.Forms.Padding(0);
            this.ApproveVolunteerBTN.Name = "ApproveVolunteerBTN";
            this.ApproveVolunteerBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ApproveVolunteerBTN.Size = new System.Drawing.Size(271, 70);
            this.ApproveVolunteerBTN.TabIndex = 1;
            this.ApproveVolunteerBTN.Text = "                 Duyệt ứng viên ";
            this.ApproveVolunteerBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApproveVolunteerBTN.UseVisualStyleBackColor = true;
            this.ApproveVolunteerBTN.Click += new System.EventHandler(this.ApproveVolunteerBTN_Click);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 879);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizationForm";
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CreateEventButoon;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button ApproveVolunteerBTN;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button SignOutBTN;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button notifyBTN;
        private System.Windows.Forms.Button DiemDanhBTN;
    }
}