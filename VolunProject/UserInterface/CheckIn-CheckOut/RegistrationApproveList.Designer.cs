namespace VolunProject.UserInterface.CheckIn_CheckOut
{
    partial class RegistrationApproveList
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
            this.label1 = new System.Windows.Forms.Label();
            this.notiPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EventNameLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách người tham gia";
            // 
            // notiPanel
            // 
            this.notiPanel.Location = new System.Drawing.Point(0, 112);
            this.notiPanel.Name = "notiPanel";
            this.notiPanel.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.notiPanel.Size = new System.Drawing.Size(1473, 752);
            this.notiPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sự kiện:";
            // 
            // EventNameLB
            // 
            this.EventNameLB.AutoSize = true;
            this.EventNameLB.BackColor = System.Drawing.Color.DarkSalmon;
            this.EventNameLB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLB.Location = new System.Drawing.Point(568, 19);
            this.EventNameLB.Name = "EventNameLB";
            this.EventNameLB.Size = new System.Drawing.Size(70, 24);
            this.EventNameLB.TabIndex = 9;
            this.EventNameLB.Text = "Gì đó";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.SearchName);
            this.panel1.Controls.Add(this.filterCB);
            this.panel1.Controls.Add(this.EventNameLB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 66);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VolunProject.Properties.Resources.icons8_back_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "  Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterCB
            // 
            this.filterCB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Location = new System.Drawing.Point(14, 17);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(144, 26);
            this.filterCB.TabIndex = 10;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.filterCB_SelectedIndexChanged);
            // 
            // SearchName
            // 
            this.SearchName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName.Location = new System.Drawing.Point(181, 16);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(251, 26);
            this.SearchName.TabIndex = 11;
            this.SearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // RegistrationApproveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationApproveList";
            this.Size = new System.Drawing.Size(1473, 879);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel notiPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EventNameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.TextBox SearchName;
    }
}
