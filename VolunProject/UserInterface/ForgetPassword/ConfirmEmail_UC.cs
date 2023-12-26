using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;

namespace VolunProject.UserInterface.ForgetPassword
{
    public partial class ConfirmEmail_UC : UserControl
    {
        public static event EventHandler BackEvent;
        public static event EventHandler GetPasswordEvent;
        public ConfirmEmail_UC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackEvent(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = accountTB.Text.ToString();
            string email = emailTB.Text.ToString();
            if (AccountBLL.checkAccountName(account) == false)
            {
                error.Text = "Tên đăng nhập không chính xác";
                error.Visible = true;
            }
            else if (VolunteerBLL.confirmEmail(account, email) == false)
            {
                error.Text = "Email không chính xác";
                error.Visible = true;
            }
            else
            {
                Random random = new Random();
                string pin = random.Next(10000).ToString("0000");
                OtherFunction.SessionManager.SetSessionValue("PIN", pin);
                OtherFunction.SessionManager.SetSessionValue("CurEmail", email);
                OtherFunction.SessionManager.SetSessionValue("CurAccount", account);
                OtherFunction.SendEmail(email, "Mã xác thực", OtherFunction.guiMailLayMK(pin));
                GetPasswordEvent(this, new EventArgs());
            }
        }
    }
}
