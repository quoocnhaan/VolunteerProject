namespace VolunProject.UserInterface.Event.OrganizationRegisterList
{
    partial class OrganizationRegisterList
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
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.registerformlist = new System.Windows.Forms.Panel();
            this.EventListCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterCountLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusCB
            // 
            this.StatusCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Location = new System.Drawing.Point(63, 66);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(236, 27);
            this.StatusCB.TabIndex = 0;
            this.StatusCB.SelectedIndexChanged += new System.EventHandler(this.StatusCB_SelectedIndexChanged);
            // 
            // registerformlist
            // 
            this.registerformlist.Location = new System.Drawing.Point(0, 149);
            this.registerformlist.Name = "registerformlist";
            this.registerformlist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.registerformlist.Size = new System.Drawing.Size(1473, 730);
            this.registerformlist.TabIndex = 4;
            // 
            // EventListCB
            // 
            this.EventListCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListCB.FormattingEnabled = true;
            this.EventListCB.Location = new System.Drawing.Point(356, 66);
            this.EventListCB.Name = "EventListCB";
            this.EventListCB.Size = new System.Drawing.Size(452, 27);
            this.EventListCB.TabIndex = 5;
            this.EventListCB.SelectedIndexChanged += new System.EventHandler(this.EventListCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Danh sách sự kiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Số lượng: ";
            // 
            // RegisterCountLB
            // 
            this.RegisterCountLB.AutoSize = true;
            this.RegisterCountLB.BackColor = System.Drawing.SystemColors.Control;
            this.RegisterCountLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCountLB.Location = new System.Drawing.Point(153, 115);
            this.RegisterCountLB.Name = "RegisterCountLB";
            this.RegisterCountLB.Size = new System.Drawing.Size(18, 19);
            this.RegisterCountLB.TabIndex = 58;
            this.RegisterCountLB.Text = "0";
            // 
            // OrganizationRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegisterCountLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EventListCB);
            this.Controls.Add(this.registerformlist);
            this.Controls.Add(this.StatusCB);
            this.Name = "OrganizationRegisterList";
            this.Size = new System.Drawing.Size(1473, 879);
            this.Load += new System.EventHandler(this.OrganizationRegisterList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.Panel registerformlist;
        private System.Windows.Forms.ComboBox EventListCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RegisterCountLB;
    }
}
