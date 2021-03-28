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
using Menu = Restaurant_Management.Model.Menu;
using MenuItem = Restaurant_Management.Model.MenuItem;

namespace Restaurant_Management.View
{
    public partial class MenuItemForm : Form
    {
        private readonly MenuItemController controller = new MenuItemController();
        private readonly RestaurantEntities context = MenuItemController.context;
        private readonly Menu menu;

        public MenuItemForm(Menu menu = null)
        {
            InitializeComponent();

            this.menu = menu;
        }

        private void MenuItem_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.MenuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.restaurantManagementDataSet.MenuItem);
            this.menuTableAdapter1.Fill(this.restaurantManagementDataSet.Menu);
            dataGrid.DataSource = controller.ViewAll();

            dataGrid.Columns["ID"].Width = 100;
            dataGrid.Columns["Name"].Width = 180;
            dataGrid.Columns["MenuName"].Width = 150;
            dataGrid.Columns["Describtion"].Visible = false;

            MenuTypeCombo.ValueMember = "ID";
            IdText.Enabled = false;
            ClearData();

            if (menu != null)
            {
                dataGrid.DataSource = controller.ViewItemsMenu(menu);
                MenuTypeCombo.SelectedIndex = MenuTypeCombo.FindStringExact(menu.Name);
                searchTextBox.Text = menu.Name;
            }
            else
            {
                dataGrid.DataSource = controller.ViewAll();
                MenuTypeCombo.SelectedIndex = -1;
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
            NameText.Text = "Enter Name";
            PriceText.Text = "Enter price";
            MenuTypeCombo.SelectedIndex = -1;
            MenuTypeCombo.Text = "Choose menu category";
            IdText.Text = "ID";
            Descriptiontext.Text = "Enter description for this item";
            saveBtn.Text = "Create";
            groupBox.Text = "Create Menu Item";
            deleteBtn.Visible = false;
        }

        public void ClearDefaults()
        {
            DefaultText(NameText, "Enter Name", true);
            DefaultText(PriceText, "Enter price", true);
            DefaultText(Descriptiontext, "Enter description for this item", true);
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "NameText")
            {
                DefaultText(textBox, "Enter Name", true);
            }
            else if (textBox.Name == "PriceText")
            {
                DefaultText(textBox, "Enter price", true);
            }
            else if (textBox.Name == "Descriptiontext")
            {
                DefaultText(textBox, "Enter description for this item", true);
            }
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
                MenuTypeCombo.SelectedIndex = MenuTypeCombo.FindStringExact(type);
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
            ClearDefaults();

            if (DataValidation())
            {
                getDate(menuItem);

                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(menuItem);

                    if (flag)
                    {
                        MessageBox.Show(null, "Item has been added to menu successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something wen wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    menuItem.ID = int.Parse(IdText.Text);

                    bool flag = controller.Update(menuItem);

                    if (flag)
                    {
                        MessageBox.Show(null, "Menu item updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something wen wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getDate(MenuItem menuItem)
        {
            menuItem.Name = NameText.Text;
            menuItem.Price = decimal.Parse(PriceText.Text);
            menuItem.Describtion = Descriptiontext.Text;
            menuItem.Menu = context.Menus.Find(MenuTypeCombo.SelectedValue);
        }

        private bool DataValidation()
        {
            bool flag = ValidateMenuType() && ValidateName() && ValidatePrice();

            return flag;
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
                MessageBox.Show(null, "Menu item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private bool ValidateName()
        {
            string input = NameText.Text.Trim();

            if (input != "Enter category name" && !Validation.IsName(input))
            {
                NameLbl.Text = "Invalid name";
                NameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                NameLbl.Text = "Name";
                NameLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            ValidatePrice();
        }

        private bool ValidatePrice()
        {
            string input = PriceText.Text.Trim();

            try
            {
                if (input != "Enter price")
                    decimal.Parse(input);

                PriceLbl.Text = "Price";
                PriceLbl.ForeColor = Color.Black;
                return true;
            }
            catch
            {
                PriceLbl.Text = "Price must be a decimal number";
                PriceLbl.ForeColor = Color.Red;
                return false;
            }
        }

        private bool ValidateMenuType()
        {
            int selected = MenuTypeCombo.SelectedIndex;

            if (selected == -1)
            {
                MenuLbl.Text = "Select menu categories";
                MenuLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                MenuLbl.Text = "Menu categories";
                MenuLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void MenuTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MenuLbl.Text == "Select menu categories" && MenuTypeCombo.SelectedIndex != -1)
            {
                MenuLbl.Text = "Menu categories";
                MenuLbl.ForeColor = Color.Black;
            }
        }
    }
}