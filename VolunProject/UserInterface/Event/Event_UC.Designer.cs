namespace VolunProject.UserInterface.Event
{
    partial class Event_UC
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
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.districtCB = new System.Windows.Forms.ComboBox();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.AllEventBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(100, 63);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(444, 41);
            this.Searchtxt.TabIndex = 1;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // startdate
            // 
            this.startdate.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(603, 63);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(498, 41);
            this.startdate.TabIndex = 2;
            this.startdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2210, 1111);
            this.panel1.TabIndex = 3;
            // 
            // cityCB
            // 
            this.cityCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(100, 142);
            this.cityCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(336, 36);
            this.cityCB.TabIndex = 4;
            this.cityCB.Text = "Chọn thành phố";
            this.cityCB.SelectedIndexChanged += new System.EventHandler(this.cityCB_SelectedIndexChanged);
            // 
            // districtCB
            // 
            this.districtCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtCB.FormattingEnabled = true;
            this.districtCB.Location = new System.Drawing.Point(603, 142);
            this.districtCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.districtCB.Name = "districtCB";
            this.districtCB.Size = new System.Drawing.Size(336, 36);
            this.districtCB.TabIndex = 5;
            this.districtCB.Text = "Chọn quận";
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(100, 196);
            this.categoryCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(839, 36);
            this.categoryCB.TabIndex = 7;
            this.categoryCB.Text = "Chọn loại";
            // 
            // enddate
            // 
            this.enddate.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Location = new System.Drawing.Point(1160, 63);
            this.enddate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(498, 41);
            this.enddate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1155, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên sự kiện";
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.Color.MistyRose;
            this.SearchBTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBTN.Image = global::VolunProject.Properties.Resources.icons8_search_641;
            this.SearchBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBTN.Location = new System.Drawing.Point(1343, 142);
            this.SearchBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(315, 75);
            this.SearchBTN.TabIndex = 58;
            this.SearchBTN.Text = "  Tìm kiếm";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // AllEventBTN
            // 
            this.AllEventBTN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AllEventBTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEventBTN.Image = global::VolunProject.Properties.Resources.icons8_search_641;
            this.AllEventBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllEventBTN.Location = new System.Drawing.Point(1692, 142);
            this.AllEventBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllEventBTN.Name = "AllEventBTN";
            this.AllEventBTN.Size = new System.Drawing.Size(315, 75);
            this.AllEventBTN.TabIndex = 59;
            this.AllEventBTN.Text = "  Tất cả";
            this.AllEventBTN.UseVisualStyleBackColor = false;
            this.AllEventBTN.Click += new System.EventHandler(this.AllEventBTN_Click);
            // 
            // Event_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllEventBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.districtCB);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.startdate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Event_UC";
            this.Size = new System.Drawing.Size(2210, 1352);
            this.Load += new System.EventHandler(this.Event_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.ComboBox districtCB;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button AllEventBTN;
    }
}
