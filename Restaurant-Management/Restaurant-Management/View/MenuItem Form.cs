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
    public partial class MenuItem_Form : Form
    {
        private readonly MenuItemController controller = new MenuItemController();
        private readonly RestaurantEntities context = MenuItemController.context;

        public MenuItem_Form()
        {
            InitializeComponent();
        }

        private void MenuItem_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.MenuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.restaurantManagementDataSet.MenuItem);
            this.menuTableAdapter1.Fill(this.restaurantManagementDataSet.Menu);
            dataGrid.DataSource = controller.ViewAll();
            UTypeCombo.ValueMember = "ID";
            UTypeCombo.SelectedIndex = -1;
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
            DefaultText(sender, "What do you want to search?", true);
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to search?", false);
        }

        private void searchBtn_active(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(Basic.ImagePath + @"\icon_search_active.png");
        }

        private void searchBtn_disactive(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(Basic.ImagePath + @"\icon_search.png");
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
                groupBox.Text = "Update Menu Item";
                deleteBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create Menu Item";
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
            NameText.Text = "Enter Item Name";
            PriceText.Text = "Enter The Item price";
            UTypeCombo.SelectedIndex = -1;
            IdText.Text = "ID";
            Descriptiontext.Text = "Enter Description";
            saveBtn.Text = "Create";
            groupBox.Text = "Create Menu Item";
            deleteBtn.Visible = false;
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];
                IdText.Text = row.Cells["ID"].Value.ToString();
                NameText.Text = row.Cells["Name"].Value.ToString();
                PriceText.Text = row.Cells["Price"].Value.ToString();
                Descriptiontext.Text = row.Cells["Describtion"].Value.ToString();
                string type = row.Cells["MenuName"].Value.ToString();
                UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(type);
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
            MenuItem menuItem = new MenuItem();
            getDate(menuItem);

            if (saveBtn.Text == "Create")
            {
                bool flag = controller.Insert(menuItem);

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
                menuItem.ID = int.Parse(IdText.Text);

                bool flag = controller.Update(menuItem);

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

        private void getDate(MenuItem menuItem)
        {
            menuItem.Name = NameText.Text;
            menuItem.Price = decimal.Parse(PriceText.Text);
            menuItem.Describtion = Descriptiontext.Text;
            menuItem.Menu= context.Menus.Find(UTypeCombo.SelectedValue);
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "NameText")
            {
                DefaultText(textBox, "Enter Item Name", true);
            }
            else if (textBox.Name == "PriceText")
            {
                DefaultText(textBox, "Enter item price", true);
            }
            else if (textBox.Name == "Descriptiontext")
            {
                DefaultText(textBox, "Enter Description", true);
            }
    
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //refresh table
            dataGrid.DataSource = controller.ViewAll();
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

        private void dataGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }
    }
}
