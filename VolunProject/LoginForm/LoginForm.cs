using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.DAL;
using VolunProject.UserInterface.ForgetPassword;
using VolunProject.Data.EntityADO.NET;
using VolunProject.UserInterface.Login;
using VolunProject.UserInterface.RegisterUser;


namespace VolunProject.LoginForm
{
    public partial class LoginForm : Form
    {
        private static UserControl activeForm;
        private object panelDesktopPane;
        private object lblTitle;
        private Main main;
        private OrganizationForm OrganizationForm;
        public static event EventHandler loginEvent;

        public LoginForm()
        {
            InitializeComponent();
            main = new Main();
            sub();
        }
        public void sub()
        {
            Login_UC.SignUpEvent += button2_Click_1;
            Login_UC.LoginEvent += Login_UC_LoginEvent;
            Register_UC.registerEvent += Register_UC_registerEvent;
            Register_UC.backEvent += Register_UC_backEvent;
            Main.signOutEvent += Main_signOutEvent;
            Login_UC.AdminLoginEvent += Login_UC_AdminLoginEvent;
            AdminRegister_UC.BackEvent += AdminRegister_UC_BackEvent;
            AdminRegister_UC.LoginEvent += AdminRegister_UC_LoginEvent;
            Login_UC.ForgetPasswordEvent += Login_UC_ForgetPasswordEvent;
            ConfirmEmail_UC.BackEvent += ConfirmEmail_UC_BackEvent;
            ConfirmEmail_UC.GetPasswordEvent += ConfirmEmail_UC_GetPasswordEvent;
            ConfirmCode_UC.GetPasswordEvent += ConfirmCode_UC_GetPasswordEvent;
            Login_UC.LoginToOrganizationMainEvent += Login_UC_LoginToOrganizationMainEvent;
            OrganizationForm.signOutEventOr += OrganizationForm_signOutEventOr;
        }

        private void ConfirmCode_UC_GetPasswordEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void ConfirmEmail_UC_GetPasswordEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.ForgetPassword.ConfirmCode_UC(), sender);
        }

        private void ConfirmEmail_UC_BackEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Login_UC_ForgetPasswordEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.ForgetPassword.ConfirmEmail_UC(), sender);
          
        }

        private void OrganizationForm_signOutEventOr(object sender, EventArgs e)
        {
            this.Show();
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
            OrganizationForm.Hide();
        }

        private void Login_UC_LoginToOrganizationMainEvent(object sender, EventArgs e)
        {

            this.Hide();
            OrganizationForm = new OrganizationForm();
            OrganizationForm.Closed += (s, args) => this.Close();
            OrganizationForm.Show();
        }
        private void AdminRegister_UC_LoginEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void AdminRegister_UC_BackEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Login_UC_AdminLoginEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.RegisterUser.AdminRegister_UC(), sender);
        }

        private void Register_UC_backEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Main_signOutEvent(object sender, EventArgs e)
        {
            this.Show();
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
            main.Hide();

        }

        private void Register_UC_registerEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Login_UC_LoginEvent(object sender, EventArgs e)
        {
            this.Hide();
            main.Closed += (s, args) => this.Close();
            main.Show();
            loginEvent(this, new EventArgs());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }
        public static void OpenChildForm(Panel panel,UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            panel.Controls.Add(a);
            panel.Tag = a;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1,new UserInterface.RegisterUser.Register_UC(),sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
