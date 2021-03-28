using Restaurant_Management.Controllers;
using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
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

namespace Restaurant_Management.View
{
    public partial class DeliveryForm : Form
    {
        private readonly DeliveryController controller = new DeliveryController();
        private readonly RestaurantEntities context = CustomerController.context;
        List<CustomerVM> customers = new List<CustomerVM>();
        int id;
        bool flag2;

        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            CustomernameText.Enabled = false;
            AddressText.Enabled = false;
            FinishBtn.Visible = false;
            UpdateBtn.Visible = false;
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
            CustomernameText.Enabled = true;
            AddressText.Enabled = true;

            string search = searchTextBox.Text;
            if (search == "" || search == "What do you want to seach?")
                MessageBox.Show(null, "Enter correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                customers = controller.PhoneSearch(search);
                if (customers.Count != 0)
                {
                    foreach (var item in customers)
                    {
                        CustomernameText.Text = item.Name;
                        AddressText.Text = item.Address;
                        id = item.ID;
                        PhoneText.Text = item.Phone;
                    }
                    PhoneLbl.Visible = false;
                    PhoneText.Visible = false;
                    UpdateBtn.Visible = true;
                    UpdateBtn.Text = "Update";
                    FinishBtn.Visible = true;
                    flag2 = true;

                }
                else
                {
                    MessageBox.Show(null, "Number Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomernameText.Text = "Enter Customer Name";
                    AddressText.Text = "Enter Customer Address";
                    CustomernameText.Enabled = true;
                    AddressText.Enabled = true;
                    PhoneLbl.Visible = true;
                    PhoneText.Visible = true;
                    PhoneText.Text = searchTextBox.Text;
                    FinishBtn.Visible = true;
                    UpdateBtn.Visible = true;
                    UpdateBtn.Text = "Add Customer";

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

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {
            Regex PhoneReg = new Regex("^[0-9]{11}$");

            string input = PhoneText.Text.Trim();
            if (!PhoneReg.IsMatch(input))
            {
                PhoneLbl.Text = "Invalid Number";
                PhoneLbl.ForeColor = Color.Red;
            }
            else
            {
                PhoneLbl.Text = "Phone";
                PhoneLbl.ForeColor = Color.Black;
            }
        }
        private void getDate(Customer customer)
        {
            customer.Name = CustomernameText.Text;
            customer.Phone = searchTextBox.Text;
            customer.Address = AddressText.Text;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                var getCustomerId = (from ci in context.Customers
                                     where ci.Phone == searchTextBox.Text
                                     select ci.ID).FirstOrDefault();
                Order order = new Order();
                var getLastOrder = (from lo in context.Orders
                                    orderby lo.ID descending
                                    select lo.ID).FirstOrDefault();

                Order editedOrder = context.Orders.Find(getLastOrder);

                editedOrder.Customer_id = getCustomerId;
                context.SaveChanges();
                MessageBox.Show(null, "Order Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            getDate(customer);
            if (UpdateBtn.Text == "Add Customer")
            {
                bool flag = controller.Insert(customer);

                if (flag)
                {
                    flag2 = flag;
                    MessageBox.Show(null, "Customer inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.ID = id;

                bool flag = controller.Update(customer);

                if (flag)
                {
                    flag2 = flag;
                    MessageBox.Show(null, "Customer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}