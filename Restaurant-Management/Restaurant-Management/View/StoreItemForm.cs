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
    public partial class StoreItemForm : Form
    {
        private readonly StoreItemController controller = new StoreItemController();
        private readonly RestaurantEntities context = StoreItemController.context;
        private readonly StoreItemType storeType;

        public StoreItemForm(StoreItemType storeType = null)
        {
            InitializeComponent();

            this.storeType = storeType;
        }

        private void StoreItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.StoreItemType' table. You can move, or remove it, as needed.
            this.storeItemTypeTableAdapter.Fill(this.restaurantManagementDataSet.StoreItemType);
            IdText.Enabled = false;
            CurrentAmountText.Enabled = false;
            ClearData();

            if (storeType != null)
            {
                dataGrid.DataSource = controller.ViewItemsType(storeType);
                ITypeCombo.SelectedIndex = ITypeCombo.FindStringExact(storeType.Name);
                searchTextBox.Text = storeType.Name;
            }
            else
            {
                ITypeCombo.SelectedIndex = -1;
                dataGrid.DataSource = controller.ViewAll();
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

            NameText.Text = "Enter name";
            RequiredAmountText.Text = "Enter Required Amount";
            CurrentAmountText.Text = "Current Amount";
            PriceText.Text = "Enter Price";
            IdText.Text = "ID";
            ITypeCombo.SelectedIndex = -1;
            saveBtn.Text = "Create";
            groupBox.Text = "Create item";
            deleteBtn.Visible = false;

            ITypeLbl.Text = "Type";
            ITypeLbl.ForeColor = Color.Black;
        }

        public void ClearDefaults()
        {
            DefaultText(NameText, "Enter name", true);
            DefaultText(RequiredAmountText, "Enter Required Amount", true);
            DefaultText(PriceText, "Enter Price", true);
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                NameText.Text = row.Cells["Name"].Value.ToString();
                PriceText.Text = row.Cells["Price"].Value.ToString();
                CurrentAmountText.Text = row.Cells["CurrentCount"].Value.ToString();
                RequiredAmountText.Text = row.Cells["RequiredCount"].Value.ToString();
                //QuantityText.Text = row.Cells["Quantity"].Value.ToString();

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
            ClearDefaults();

            if (DataValidation())
            {
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
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getDate(StoreItem storeItem)
        {
            storeItem.Name = NameText.Text;
            //storeItem.CurrentCount = int.Parse(CurrentAmountText.Text);
            storeItem.RequiredCount = int.Parse(RequiredAmountText.Text);
            storeItem.Price = int.Parse(PriceText.Text);
            storeItem.StoreItemType = context.StoreItemTypes.Find(ITypeCombo.SelectedValue);
            //storeItem.Quantity = int.Parse(QuantityText.Text);
        }

        private bool DataValidation()
        {
            bool flag = ValidateItemType() && ValidateName() && ValidatePrice() && ValidateAmount();

            return flag;
        }

        private void RequiredAmountText_TextChanged(object sender, EventArgs e)
        {
            ValidateAmount();
        }

        private bool ValidateAmount()
        {
            string input = RequiredAmountText.Text.Trim();

            if (input != "Enter Required Amount" && !Validation.isInteger(input))
            {
                RequiredAmountLbl.Text = "Amount must be an integer";
                RequiredAmountLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                RequiredAmountLbl.Text = "Required Amount";
                RequiredAmountLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "NameText")
            {
                DefaultText(textBox, "Enter name", true);
            }
            //else if (textBox.Name == "CurrentAmountText")
            //{
            //    DefaultText(textBox, "Enter Current Amount", true);
            //}
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

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private bool ValidateName()
        {
            string input = NameText.Text.Trim();

            if (input != "Enter name" && !Validation.IsName(input))
            {
                ItemnameLbl.Text = "Invalid Name";
                ItemnameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                ItemnameLbl.Text = "Name";
                ItemnameLbl.ForeColor = Color.Black;
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

            if (input != "Enter Price" && !Validation.IsDecimal(input))
            {
                PriceLbl.Text = "Invalid Price";
                PriceLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                PriceLbl.Text = "Enter Price";
                PriceLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private bool ValidateItemType()
        {
            int selected = ITypeCombo.SelectedIndex;

            if (selected == -1)
            {
                ITypeLbl.Text = "Select Type";
                ITypeLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                ITypeLbl.Text = "Type";
                ITypeLbl.ForeColor = Color.Black;
                return true;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.storeItemTableAdapter.FillBy(this.restaurantManagementDataSet.StoreItem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}