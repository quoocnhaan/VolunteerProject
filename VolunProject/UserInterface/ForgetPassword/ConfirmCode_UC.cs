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
    public partial class ConfirmCode_UC : UserControl
    {
        public int countdown = 60 * 5;
        public static event EventHandler GetPasswordEvent;
        public ConfirmCode_UC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                --countdown;
                TimeDisplay();
            }
            else
            {
                OtherFunction.SessionManager.RemoveSession("PIN");
                message.Text = "Mã PIN đã hết thời gian hiệu lực";
                timer1.Stop();
            }
        }
        private void TimeDisplay()
        {
            int minute = countdown / 60;
            int second = countdown % 60;
            if(second>=10) timeLB.Text = $"{minute}:{second}";
            else timeLB.Text = $"{minute}:{0}{second}";
        }

        private void ConfirmCode_UC_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void resendButton_Click(object sender, EventArgs e)
        {
            string email = OtherFunction.SessionManager.GetSessionValue<string>("CurEmail");
            Random random = new Random();
            string pin = random.Next(10000).ToString("0000");
            OtherFunction.SendEmail(email, "Mã xác thực", pin);
            OtherFunction.SessionManager.SetSessionValue("PIN", pin);
            countdown = 60 * 5;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pin = OtherFunction.SessionManager.GetSessionValue<string>("PIN");
            string accountName = OtherFunction.SessionManager.GetSessionValue<string>("CurAccount");
            string password = AccountBLL.GetPassword(accountName);
            string email = OtherFunction.SessionManager.GetSessionValue<string>("CurEmail");
            if(pin == codeTB.Text)
            {
                
                OtherFunction.SendEmail(email, "Mật khẩu", OtherFunction.templateLayMK(accountName,password));
                MessageBox.Show("Vui lòng kiểm tra mail để lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK);
                GetPasswordEvent(this, new EventArgs());
            }
            else
            {
                message.Text = "Mã xác nhận không chính xác";
                message.Visible = true;
            }
        }
    }
}
