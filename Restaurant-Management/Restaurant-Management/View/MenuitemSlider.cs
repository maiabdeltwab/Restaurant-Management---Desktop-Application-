using Restaurant_Management.Controllers;
using Restaurant_Management.Model;
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
    public partial class MenuitemSlider : Form
    {
        public MenuitemSlider()
        {
            InitializeComponent();
        }

        public int id { get; set; }

        public MenuitemSlider(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void MenuitemSlider_Load(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
        }

        private void Pervious_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void Countious_Click(object sender, EventArgs e)
        {
            Menu_Namess objForm = new Menu_Namess();
            objForm.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}