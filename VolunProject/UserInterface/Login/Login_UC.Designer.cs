namespace VolunProject.UserInterface.Login
{
    partial class Login_UC
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
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.registerAdminButton = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showImg = new System.Windows.Forms.PictureBox();
            this.closeImg = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(84, 613);
            this.userPassword.Margin = new System.Windows.Forms.Padding(6);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '●';
            this.userPassword.Size = new System.Drawing.Size(1474, 71);
            this.userPassword.TabIndex = 2;
            this.userPassword.TextChanged += new System.EventHandler(this.userPassword_TextChanged);
            this.userPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userPassword_KeyDown);
            // 
            // userLogin
            // 
            this.userLogin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.Location = new System.Drawing.Point(84, 500);
            this.userLogin.Margin = new System.Windows.Forms.Padding(6);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(1474, 71);
            this.userLogin.TabIndex = 1;
            this.userLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userLogin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(576, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 125);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng nhập";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(92, 415);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(139, 43);
            this.errorMessage.TabIndex = 10;
            this.errorMessage.Text = "label2";
            this.errorMessage.Visible = false;
            // 
            // registerAdminButton
            // 
            this.registerAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.registerAdminButton.FlatAppearance.BorderSize = 0;
            this.registerAdminButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerAdminButton.Location = new System.Drawing.Point(810, 750);
            this.registerAdminButton.Margin = new System.Windows.Forms.Padding(6);
            this.registerAdminButton.Name = "registerAdminButton";
            this.registerAdminButton.Size = new System.Drawing.Size(262, 83);
            this.registerAdminButton.TabIndex = 5;
            this.registerAdminButton.Text = "Admin";
            this.registerAdminButton.UseVisualStyleBackColor = false;
            this.registerAdminButton.Click += new System.EventHandler(this.registerAdminButton_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.login.FlatAppearance.BorderSize = 0;
            this.login.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(130, 750);
            this.login.Margin = new System.Windows.Forms.Padding(6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(320, 83);
            this.login.TabIndex = 3;
            this.login.Text = "Đăng nhập";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.signup.FlatAppearance.BorderSize = 0;
            this.signup.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup.Location = new System.Drawing.Point(490, 750);
            this.signup.Margin = new System.Windows.Forms.Padding(6);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(276, 83);
            this.signup.TabIndex = 4;
            this.signup.Text = "Đăng ký";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1132, 750);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quên MK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showImg
            // 
            this.showImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showImg.Image = global::VolunProject.Properties.Resources.icons8_invisible_50;
            this.showImg.Location = new System.Drawing.Point(1558, 613);
            this.showImg.Margin = new System.Windows.Forms.Padding(6);
            this.showImg.Name = "showImg";
            this.showImg.Size = new System.Drawing.Size(70, 71);
            this.showImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showImg.TabIndex = 12;
            this.showImg.TabStop = false;
            this.showImg.Click += new System.EventHandler(this.showImg_Click);
            // 
            // closeImg
            // 
            this.closeImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.closeImg.Image = global::VolunProject.Properties.Resources.icons8_invisible_48;
            this.closeImg.Location = new System.Drawing.Point(1558, 613);
            this.closeImg.Margin = new System.Windows.Forms.Padding(6);
            this.closeImg.Name = "closeImg";
            this.closeImg.Size = new System.Drawing.Size(70, 71);
            this.closeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeImg.TabIndex = 11;
            this.closeImg.TabStop = false;
            this.closeImg.Click += new System.EventHandler(this.closeImg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::VolunProject.Properties.Resources.icons8_password_24;
            this.pictureBox2.Location = new System.Drawing.Point(0, 613);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_user_24;
            this.pictureBox1.Location = new System.Drawing.Point(0, 500);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showImg);
            this.Controls.Add(this.closeImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registerAdminButton);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login_UC";
            this.Size = new System.Drawing.Size(1672, 1381);
            this.Load += new System.EventHandler(this.Login_UC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_UC_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.showImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button registerAdminButton;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox closeImg;
        private System.Windows.Forms.PictureBox showImg;
    }
}
