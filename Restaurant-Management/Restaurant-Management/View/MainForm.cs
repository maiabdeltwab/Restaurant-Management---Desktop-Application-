using Restaurant_Management.Controllers;
using Restaurant_Management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DatabaseListForm objForm = new DatabaseListForm();
            objForm.TopLevel = false;
            mainPanel.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            DatabaseListForm objForm = new DatabaseListForm();
            objForm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            ItemDailyNeedForm objForm = new ItemDailyNeedForm();
            objForm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserController control = new UserController();
            control.Logout();
            App.UserLogin = null;

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Menu_Namess objForm = new Menu_Namess();
            objForm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}