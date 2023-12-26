using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;

namespace VolunProject.UserInterface.Login
{
    public partial class Login_UC : UserControl
    {
        public static event EventHandler SignUpEvent;
        public static event EventHandler LoginEvent;
        public static event EventHandler AdminLoginEvent;
        public static event EventHandler ForgetPasswordEvent;
        public static event EventHandler LoginToOrganizationMainEvent;
        public Login_UC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUpEvent(this, new EventArgs());
        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userLogin.Text;
            string password = userPassword.Text;
            if (userName == "")
            {
                errorMessage.Text = "Vui lòng nhập tài khoản!";
                errorMessage.Visible = true;
            }
            else if (password == "")
            {
                errorMessage.Text = "Vui lòng nhập mật khẩu !";
                errorMessage.Visible = true;
            }
            else if (AccountBLL.checkAccountName(userName) == false)
            {
                errorMessage.Text = "Tài khoản không đúng !";
                errorMessage.Visible = true;
            }
            else if (AccountBLL.checkPassword(userName, password) == false)
            {
                errorMessage.Text = "Mật khẩu không đúng !";
                errorMessage.Visible = true;
            }
            else {
                if (AccountBLL.LogIn(userLogin.Text, userPassword.Text))
                {
                    var account = AccountBLL.Account_ByLoginName(userLogin.Text);
                    if (account.RoleName == "ORGANIZATION")
                    {
                        LoginToOrganizationMainEvent(this, new EventArgs());
                    }
                    else
                    {
                        LoginEvent(this, new EventArgs());
                    }
                    errorMessage.Visible = false;
                }
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUpEvent(this, new EventArgs());
        }

        private void registerAdminButton_Click(object sender, EventArgs e)
        {
            AdminLoginEvent(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPasswordEvent(this, new EventArgs());
        }

        private void Login_UC_Load(object sender, EventArgs e)
        {

        }

        private void closeImg_Click(object sender, EventArgs e)
        {
            showImg.BringToFront();
            userPassword.PasswordChar = '●';
            
        }

        private void showImg_Click(object sender, EventArgs e)
        {

            closeImg.BringToFront();
            userPassword.PasswordChar = '\0';
            
        }

        private void Login_UC_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void userPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }

        private void userLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }
    }
}
