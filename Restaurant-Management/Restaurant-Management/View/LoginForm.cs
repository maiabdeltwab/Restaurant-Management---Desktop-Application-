using Restaurant_Management.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.View
{
    public partial class LoginForm : Form
    {
        private readonly UserController Controller = new UserController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ErrorLbl.Visible = false;
        }

        private void viewPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            passwordText.UseSystemPasswordChar = (viewPassCheck.Checked) ? true : false;
            passwordText.PasswordChar = (viewPassCheck.Checked) ? '●' : '\0';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = usernameText.Text,
                Password = passwordText.Text
            };

            user = Controller.Login(user);

            if (user != null)
            {
                if (user.Password == null)
                {
                    ErrorLbl.Text = "Incorrect password";
                    ErrorLbl.Visible = true;
                }
                else
                {
                    App.UserLogin = user;

                    Main mainForm = new Main();
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                ErrorLbl.Text = "Incorrect username or email";
                ErrorLbl.Visible = true;
            }
        }

        private void rememberCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void usernameText_Enter(object sender, EventArgs e)
        {
            if (usernameText.Text == "Enter email/username")
                usernameText.Text = "";
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.Text == "")
                usernameText.Text = "Enter email/username";
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "Enter your password")
                passwordText.Text = "";
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
                passwordText.Text = "Enter your password";
        }
    }
}