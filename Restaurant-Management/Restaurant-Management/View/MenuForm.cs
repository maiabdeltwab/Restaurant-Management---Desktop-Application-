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

namespace Restaurant_Management.View
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            dataGrid.Columns["ID"].Width = 200;
        }

        private readonly MenuController controller = new MenuController();
        private readonly RestaurantEntities context = MenuController.context;

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantManagementDataSet.Menu);
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
                groupBox.Text = "Update menu category";

                deleteBtn.Visible = true;
                itemBtn.Visible = true;

                SelectRow();
            }
            else
            {
                groupBox.Text = "Create menu category";

                deleteBtn.Visible = false;
                itemBtn.Visible = false;

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

            nameText.Text = "Enter category name";
            IdText.Text = "ID";

            saveBtn.Text = "Create";
            groupBox.Text = "Create menu category";
            deleteBtn.Visible = false;
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];
                IdText.Text = row.Cells["ID"].Value.ToString();
                nameText.Text = row.Cells["Names"].Value.ToString();

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
            if (nameText.Text == "Enter category name")
                nameText.Text = "";

            Menu menu = new Menu();
            getDate(menu);

            if (Validation.IsName(menu.Name))
            {
                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(menu);

                    if (flag)
                    {
                        MessageBox.Show(null, "Category inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    menu.ID = int.Parse(IdText.Text);

                    bool flag = controller.Update(menu);

                    if (flag)
                    {
                        MessageBox.Show(null, "Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getDate(Menu menu)
        {
            menu.Name = nameText.Text.Trim();
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
                MessageBox.Show(null, "Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            string input = nameText.Text.Trim();

            if (input != "Enter category name" && !Validation.IsName(input))
            {
                NameLbl.Text = "Invalid name";
                NameLbl.ForeColor = Color.Red;
            }
            else
            {
                NameLbl.Text = "Name";
                NameLbl.ForeColor = Color.Black;
            }
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            if (nameText.Text == "Enter category name")
                DefaultText(sender, "Enter category name", true);
        }

        private void itemssBtn_Click(object sender, EventArgs e)
        {
            Menu menuType = controller.GetMenuType(int.Parse(IdText.Text));
            MenuItemForm menuItemForm = new MenuItemForm(menuType)
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(menuItemForm);
            menuItemForm.FormBorderStyle = FormBorderStyle.None;
            menuItemForm.Dock = DockStyle.Fill;
            menuItemForm.Show();
        }
    }
}