using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.UserInterface.RegisterUser
{
    public partial class AdminRegister_UC : UserControl
    {
        public static event EventHandler LoginEvent;
        public static event EventHandler BackEvent;
        public AdminRegister_UC()
        {
            InitializeComponent();
        }

        private void AdminRegister_UC_Load(object sender, EventArgs e)
        {
            organizeComboBox.DataSource = OrganizationBLL.getOrganization();
            organizeComboBox.DisplayMember = "OrganizationName";
            organizeComboBox.ValueMember = "OrganizationID";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BackEvent(this, new EventArgs());
        }
        private bool ContainsSpecialCharacters(string input)
        {
            Regex regex = new Regex(@"[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]");
            return regex.IsMatch(input);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.EndsWith("@gmail.com");
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string pin = pinCodeTextBox.Text;
            string orgID = (string) organizeComboBox.SelectedValue;
            var organization = OrganizationBLL.getOrganizationByID(orgID);
            if(pin == "")
            {
                errorMessage.Text = "Vui lòng nhập mã PIN !";
                errorMessage.Visible = true;
            }
            else if (email == "")
            {
                errorMessage.Text = "Vui lòng nhập email !";
                errorMessage.Visible = true;
            }
            else if (username == "")
            {
                errorMessage.Text = "Vui lòng nhập tên đăng nhập !";
                errorMessage.Visible = true;
            }
            else if (password == "")
            {
                errorMessage.Text = "Vui lòng nhập mật khẩu !";
                errorMessage.Visible = true;
            }
            else if (confirmPassword == "")
            {
                errorMessage.Text = "Vui lòng xác nhận mật khẩu !";
                errorMessage.Visible = true;
            }
            else if (organization.COCK != pin)
            {
                errorMessage.Text = "Mã pin không đúng !";
                errorMessage.Visible = true;
            }
            else if (VolunteerBLL.checkEmail(email))
            {
                errorMessage.Text = "Email đã được sử dụng !";
                errorMessage.Visible = true;
            }
            else if (!IsValidEmail(email))
            {
                errorMessage.Text = "Địa chỉ email không hợp lệ. Vui lòng nhập đúng định dạng @gmail.com";
                errorMessage.Visible = true;
            }
            else if (username.Length < 8 || username.Length > 15)
            {
                errorMessage.Text = "Tên đăng nhập phải có từ 8 đến 15 ký tự !";
                errorMessage.Visible = true;
            }
            else if (ContainsSpecialCharacters(username))
            {
                errorMessage.Text = "Tên đăng nhập không được chứa ký tự đặc biệt !";
                errorMessage.Visible = true;
            }
            else if (confirmPassword != password)
            {
                errorMessage.Text = "Mật khẩu không trùng khớp !";
                errorMessage.Visible = true;
            }
            else if (password.Length < 8)
            {
                errorMessage.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                errorMessage.Visible = true;
            }
            else if (AccountBLL.checkAccountName(username))
            {
                errorMessage.Text = "Tên đăng nhập đã tồn tại !";
                errorMessage.Visible = true;
            }
            else
            {
                AccountDTO accountDTO = new AccountDTO();
                accountDTO.OrganizationID = (string)organizeComboBox.SelectedValue;
                accountDTO.AccountName = username;
                accountDTO.Password = password;
                accountDTO.Email = email;
                if (OrganizationBLL.SignUp(accountDTO))
                {
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    LoginEvent(this, new EventArgs());
                }
            }
        }

        private void showImg_Click(object sender, EventArgs e)
        {
            closeImg.BringToFront();
            passwordTextBox.PasswordChar = '\0';
        }

        private void closeImg_Click(object sender, EventArgs e)
        {
            showImg.BringToFront();
            passwordTextBox.PasswordChar = '●';
        }

        private void close_Click(object sender, EventArgs e)
        {
            show.BringToFront();
            confirmPasswordTextBox.PasswordChar = '●';     
        }

        private void show_Click(object sender, EventArgs e)
        {
            close.BringToFront();
            confirmPasswordTextBox.PasswordChar = '\0';
        }

        private void pinCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void confirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
