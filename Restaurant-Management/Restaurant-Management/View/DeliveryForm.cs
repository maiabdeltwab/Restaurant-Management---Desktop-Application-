using Restaurant_Management.Controllers;
using Restaurant_Management.ViewModel;
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
    public partial class DeliveryForm : Form
    {
        private readonly DeliveryController controller = new DeliveryController();
        private readonly RestaurantEntities context = CustomerController.context;

        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
        }

        private void searchBtn_active(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search_active.png");
        }

        private void searchBtn_disactive(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search.png");
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", true);
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", false);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void search(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            if (search == "" || search == "What do you want to seach?")
                MessageBox.Show(null, "Enter correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<CustomerVM> customers = new List<CustomerVM>();

                customers = controller.PhoneSearch(search);
                if (customers.Count > 0)
                {
                    foreach (var item in customers)
                    {
                        CustomernameText.Text = item.Name;
                        AddressText.Text = item.Address;
                    }
                }
                else
                {
                    MessageBox.Show(null, "Number Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomernameText.Text = "";
                    AddressText.Text = "";
                }
            }
        }

        private void DefaultText(dynamic textBox, string defaultText, bool remove)
        {
            if (remove)
            {
                if (textBox.Text == defaultText)
                    textBox.Text = "";
            }
            else
            {
                if (textBox.Text == "" || string.IsNullOrWhiteSpace(textBox.Text))
                    textBox.Text = defaultText;
            }
        }

        private void AddresLbl_Click(object sender, EventArgs e)
        {
        }
    }
}