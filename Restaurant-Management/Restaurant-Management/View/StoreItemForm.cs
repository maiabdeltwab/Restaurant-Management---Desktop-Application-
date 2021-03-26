using Restaurant_Management.Controllers;
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
    public partial class StoreItemForm : Form
    {
        private readonly StoreItemController controller = new StoreItemController();
        private readonly RestaurantEntities context = StoreItemController.context;

        public StoreItemForm()
        {
            InitializeComponent();
        }

        private void StoreItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.
            this.itemTypeTableAdapter.Fill(this.restaurantManagementDataSet.StoreItemType);

            dataGrid.DataSource = controller.ViewAll();

            ITypeCombo.SelectedIndex = -1;
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
                groupBox.Text = "Update item";
                deleteBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create item";
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

            ItemnameText.Text = "Enter itemname";
            CurrentAmountText.Text = "Enter Current Amount";
            RequiredAmountText.Text = "Enter Required Amount";
            PriceText.Text = "Enter Price";
            IdText.Text = "ID";
            QuantityText.Text = "Enter Quantity";
            ITypeCombo.SelectedIndex = -1;
            saveBtn.Text = "Create";
            groupBox.Text = "Create item";
            deleteBtn.Visible = false;
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                ItemnameText.Text = row.Cells["Name"].Value.ToString();
                PriceText.Text = row.Cells["Price"].Value.ToString();
                CurrentAmountText.Text = row.Cells["CurrentCount"].Value.ToString();
                RequiredAmountText.Text = row.Cells["RequiredCount"].Value.ToString();
                QuantityText.Text = row.Cells["Quantity"].Value.ToString();

                string type = row.Cells["TypeName"].Value.ToString();
                ITypeCombo.SelectedIndex = ITypeCombo.FindStringExact(type);

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
            StoreItem storeItem = new StoreItem();
            getDate(storeItem);

            if (saveBtn.Text == "Create")
            {
                bool flag = controller.Insert(storeItem);

                if (flag)
                {
                    MessageBox.Show(null, "item inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                storeItem.ID = int.Parse(IdText.Text);

                bool flag = controller.Update(storeItem);

                if (flag)
                {
                    MessageBox.Show(null, "item updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();
                }
                else
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDate(StoreItem storeItem)
        {
            storeItem.Name = ItemnameText.Text;
            storeItem.CurrentCount = int.Parse(CurrentAmountText.Text);
            storeItem.RequiredCount = int.Parse(RequiredAmountText.Text);
            storeItem.Price = int.Parse(PriceText.Text);
            storeItem.StoreItemType = context.StoreItemTypes.Find(ITypeCombo.SelectedValue);
            storeItem.Quantity = int.Parse(QuantityText.Text);
        }

        private void LNameText_TextChanged(object sender, EventArgs e)
        {
            Regex nameReg = new Regex("^[0-9]*$");

            string input = RequiredAmountText.Text.Trim();
            if (input != "Enter Required Amount" && !nameReg.IsMatch(input))
            {
                RequiredAmountLbl.Text = "Invalid Required Amount";
                RequiredAmountLbl.ForeColor = Color.Red;
            }
            else
            {
                RequiredAmountLbl.Text = "Enter Required Amount";
                RequiredAmountLbl.ForeColor = Color.Black;
            }
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "Itemname")
            {
                DefaultText(textBox, "Enter itemname", true);
            }
            else if (textBox.Name == "CurrentAmountText")
            {
                DefaultText(textBox, "Enter Current Amount", true);
            }
            else if (textBox.Name == "RequiredAmountText")
            {
                DefaultText(textBox, "Enter Required Amount", true);
            }
            else if (textBox.Name == "PriceText")
            {
                DefaultText(textBox, "Enter Price", true);
            }
            else if (textBox.Name == "QuantityText")
            {
                DefaultText(textBox, "Enter Quantity", true);
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

            string input = ItemnameText.Text.Trim();

            if (input != "Enter itemname" && !usernameReg.IsMatch(input))
            {
                ItemnameLbl.Text = "Invalid ItemName";
                ItemnameLbl.ForeColor = Color.Red;
            }
            else
            {
                ItemnameLbl.Text = "Enter itemname";
                ItemnameLbl.ForeColor = Color.Black;
            }
        }

        private void FNameText_TextChanged(object sender, EventArgs e)
        {
            Regex nameReg = new Regex("^[0-9]*$");

            string input = CurrentAmountText.Text.Trim();
            if (input != "Enter Current Amount" && !nameReg.IsMatch(input))
            {
                CurrentAmountLbl.Text = "Invalid Current Amount";
                CurrentAmountLbl.ForeColor = Color.Red;
            }
            else
            {
                CurrentAmountLbl.Text = "Enter Current Amount";
                CurrentAmountLbl.ForeColor = Color.Black;
            }
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            Regex emailReg = new Regex("^[0-9]*$");

            string input = PriceText.Text.Trim();

            if (input != "Enter Price" && !emailReg.IsMatch(input))
            {
                PriceLbl.Text = "Invalid Price";
                PriceLbl.ForeColor = Color.Red;
            }
            else
            {
                PriceLbl.Text = "Enter Price";
                PriceLbl.ForeColor = Color.Black;
            }
        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {
            Regex emailReg = new Regex("^[0-9]*$");

            string input = QuantityText.Text.Trim();

            if (input != "Enter Quantity" && !emailReg.IsMatch(input))
            {
                QuantityLbl.Text = "Invalid Quantity";
                QuantityLbl.ForeColor = Color.Red;
            }
            else
            {
                QuantityLbl.Text = "Enter Quantity";
                QuantityLbl.ForeColor = Color.Black;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdText.Text);

            if (controller.Delete(id))
            {
                MessageBox.Show(null, "item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storeItemTableAdapter.FillBy(this.restaurantManagementDataSet.StoreItem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {
        }

        private void ITypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ItemnameLbl_Click(object sender, EventArgs e)
        {
        }
    }
}