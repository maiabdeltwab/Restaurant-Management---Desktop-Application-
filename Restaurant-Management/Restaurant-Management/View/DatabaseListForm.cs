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
    public partial class DatabaseListForm : Form
    {
        public DatabaseListForm()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm objForm = new MenuForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void menuItemBtn_Click(object sender, EventArgs e)
        {
            MenuItemForm objForm = new MenuItemForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void storeTypesBtn_Click(object sender, EventArgs e)
        {
            StoreItemTypesForm objForm = new StoreItemTypesForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void storeItemBtn_Click(object sender, EventArgs e)
        {
            StoreItemForm objForm = new StoreItemForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void shipmentsBtn_Click(object sender, EventArgs e)
        {
            ItemShipmentForm objForm = new ItemShipmentForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm objForm = new CustomerForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrdersForm objForm = new OrdersForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void userTypeBtn_Click(object sender, EventArgs e)
        {
            UserTypeForm objForm = new UserTypeForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UserForm objForm = new UserForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            SupplierForm objForm = new SupplierForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}