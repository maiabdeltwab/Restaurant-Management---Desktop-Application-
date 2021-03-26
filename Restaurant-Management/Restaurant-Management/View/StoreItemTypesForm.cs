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
    public partial class StoreItemTypesForm : Form
    {
        private readonly StoreItemTypeController controller = new StoreItemTypeController();
        private readonly RestaurantEntities context = StoreItemTypeController.context;

        public StoreItemTypesForm()
        {
            InitializeComponent();
        }

        private void StoreItemTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.

            dataGrid.DataSource = controller.ViewAll();

            IdText.Enabled = false;
            ClearData();
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

        private void searchBtn_active(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search_active.png");
        }

        private void searchBtn_disactive(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search.png");
        }

        private void dataGrid_Leave(object sender, EventArgs e)
        {
            //dataGrid.ClearSelection();
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClearData();
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

        private void search(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            if (search == "" || search == "What do you want to seach?")
                dataGrid.DataSource = controller.ViewAll();
            else
                dataGrid.DataSource = controller.Search(search);
        }

        private void dataGrid_rowCountChange(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void dataGrid_rowCountChange(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }

        private void ClearData()
        {
            dataGrid.ClearSelection();

            NameText.Text = "Enter Name";
            IdText.Text = "ID";
            saveBtn.Text = "Create";
            groupBox.Text = "Create user";
            deleteBtn.Visible = false;
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                NameText.Text = row.Cells["Name"].Value.ToString();
                saveBtn.Text = "Update";
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StoreItemType storeItemType = new StoreItemType();
            getDate(storeItemType);

            if (saveBtn.Text == "Create")
            {
                bool flag = controller.Insert(storeItemType);

                if (flag)
                {
                    MessageBox.Show(null, "User inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                storeItemType.ID = int.Parse(IdText.Text);

                bool flag = controller.Update(storeItemType);

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

        private void getDate(StoreItemType storeItemType)
        {
            storeItemType.Name = NameText.Text;
        }

        private void LNameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "EmailText")
            {
                DefaultText(textBox, "Enter email", true);
            }
            else if (textBox.Name == "FNameText")
            {
                DefaultText(textBox, "Enter first name", true);
            }
            else if (textBox.Name == "LNameText")
            {
                DefaultText(textBox, "Enter last name", true);
            }
            else if (textBox.Name == "PasswordText")
            {
                DefaultText(textBox, "Enter password", true);
            }
            else if (textBox.Name == "Name")
            {
                DefaultText(textBox, "Enter Name", true);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //refresh table
            dataGrid.DataSource = controller.ViewAll();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            Regex usernameReg = new Regex("^([a-z0-9]|[-._](?![-._])){3,}$");

            string input = NameText.Text.Trim();

            if (input != "Name" && !usernameReg.IsMatch(input))
            {
                UsernameLbl.Text = "Invalid Name";
                UsernameLbl.ForeColor = Color.Red;
            }
            else
            {
                UsernameLbl.Text = "Name";
                UsernameLbl.ForeColor = Color.Black;
            }
        }

        private void FNameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
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
    }
}