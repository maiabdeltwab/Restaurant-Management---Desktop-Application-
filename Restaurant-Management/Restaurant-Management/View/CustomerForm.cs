using Restaurant_Management.Controllers;
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
    public partial class CustomerForm : Form
    {
        private readonly CustomerController controller = new CustomerController();
        private readonly RestaurantEntities context = CustomerController.context;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //this.userTypeTableAdapter.Fill(this.restaurantManagementDataSet.UserType);

            dataGrid.DataSource = controller.ViewAll();

            //UTypeCombo.SelectedIndex = -1;
            IdText.Enabled = false;
            ClearData();
        }

        private void IdLbl_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLbl_Click(object sender, EventArgs e)
        {

        }
        private void dataGrid_rowCountChange(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void dataGrid_rowCountChange(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }
        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                groupBox.Text = "Update user";
                deleteBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create user";
                deleteBtn.Visible = false;
                ClearData();
            }
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];
                IdText.Text = row.Cells["ID"].Value.ToString();
                CustomernameText.Text = row.Cells["Name"].Value.ToString();
                PhoneText.Text = row.Cells["Phone"].Value.ToString();

                //EmailText.Text = row.Cells["Email"].Value.ToString();
                //FNameText.Text = row.Cells["FristName"].Value.ToString();
                //LNameText.Text = row.Cells["LastName"].Value.ToString();

                //string type = row.Cells["TypeName"].Value.ToString();
                //UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(type);

                saveBtn.Text = "Update";
            }
        }
        private void ClearData()
        {
            dataGrid.ClearSelection();

            CustomernameText.Text = "Enter Customer name";
            PhoneText.Text = "Enter phone number";
            IdText.Text = "ID";
            saveBtn.Text = "Create";
            groupBox.Text = "Create Customer";
            deleteBtn.Visible = false;
        }
        private void CustomernameText_TextChanged(object sender, EventArgs e)
        {
            Regex CustomernameReg = new Regex("^([a-z0-9]|[-._](?![-._])){3,}$"); 

            string input = CustomernameText.Text.Trim();

            if (input != "Enter Customer name" && !CustomernameReg.IsMatch(input))
            {
                CustomernameLbl.Text = "Invalid Customername";
                CustomernameLbl.ForeColor = Color.Red;
            }
            else
            {
                CustomernameLbl.Text = "Customername";
                CustomernameLbl.ForeColor = Color.Black;
            }
        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {
            Regex PhoneReg = new Regex("^[0-9]{11}$");

            string input = PhoneText.Text.Trim();

            if (input != "Enter phone number" && !PhoneReg.IsMatch(input))
            {
                PhoneLbl.Text = "Invalid Phone Number";
                PhoneLbl.ForeColor = Color.Red;
            }
            else
            {
                PhoneLbl.Text = "Phone Number";
                PhoneLbl.ForeColor = Color.Black;
            }
        }
        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "CustomernameText")
            {
                DefaultText(textBox, "Enter Customer name", true);
            }
            else if (textBox.Name == "PhoneText")
            {
                DefaultText(textBox, "Enter phone number", true);
            }
        }
        private void PhoneLbl_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            getDate(customer);

            if (saveBtn.Text == "Create")
            {
                bool flag = controller.Insert(customer);

                if (flag)
                {
                    MessageBox.Show(null, "Customer inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.ID = int.Parse(IdText.Text);

                bool flag = controller.Update(customer);

                if (flag)
                {
                    MessageBox.Show(null, "User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getDate(Customer customer)
        {
            customer.Name = CustomernameText.Text;
            customer.Phone = PhoneText.Text;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.ViewAll();
        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdText.Text);

            if (controller.Delete(id))
            {
                MessageBox.Show(null, "User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClearData();
        }
        private void searchBtn_active(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(Basic.ImagePath + @"\icon_search_active.png");
        }

        private void searchBtn_disactive(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(Basic.ImagePath + @"\icon_search.png");
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
        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", true);
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", false);
        }
        private void dataGrid_Leave(object sender, EventArgs e)
        {
            //dataGrid.ClearSelection();
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
                dataGrid.DataSource = controller.ViewAll();
            else
                dataGrid.DataSource = controller.Search(search);
        }
    }
}
