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
    public partial class ItrmShipmentForm : Form
    {
        private readonly ItemShipmentController controller = new ItemShipmentController();
        private readonly RestaurantEntities context = ItemShipmentController.context;

        private readonly Supplier supplier = null;
        private readonly StoreItem storeItem = null;


        private readonly Regex count = new Regex("^[0-9]+$");     
        public ItrmShipmentForm(Supplier supplier = null , StoreItem storeItem = null)
        {
            InitializeComponent();

            this.supplier = supplier;
            this.storeItem = storeItem;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.StoreItem' table. You can move, or remove it, as needed.
            this.storeItemTableAdapter.Fill(this.restaurantManagementDataSet.StoreItem);
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.restaurantManagementDataSet.Supplier);

            IdText.Enabled = false;
            ClearData();

            if (supplier != null && storeItem!=null)
            {
                dataGrid.DataSource = controller.ViewshipmentDetails(supplier,storeItem);
                UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(supplier.Name);
                comboBox1.SelectedIndex = comboBox1.FindStringExact(storeItem.Name);

                searchTextBox.Text = supplier.Name;
            }
            else if (storeItem != null)
            {
                dataGrid.DataSource = controller.ViewshipmentstoreItem(storeItem);
                comboBox1.SelectedIndex = comboBox1.FindStringExact(storeItem.Name);
                searchTextBox.Text = storeItem.Name;
            }
            else if (supplier!=null)
            {
                dataGrid.DataSource = controller.Viewshipmentsupplier(supplier);
                UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(supplier.Name);
                searchTextBox.Text = supplier.Name;
            }
            else
            {
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
                groupBox.Text = "Update shipment";
                deleteBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create shipment";
                deleteBtn.Visible = false;
                ClearData();
            }
        }

        private void search(object sender, EventArgs e)
        {
            string search = searchTextBox.Text.Trim();
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

            CountText.Text = "Count";
            IdText.Text = "ID";
            UTypeCombo.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            UTypeCombo.Text = "Select a supplier";
            comboBox1.Text = "Select a store item";
            saveBtn.Text = "Create";
            groupBox.Text = "Create shipment";
            deleteBtn.Visible = false;
        }

        public void ClearDefaults()
        {
            DefaultText(CountText, "Count", true);

        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ArrivalTime"].Value.ToString();
                dateTimePicker2.Text = row.Cells["ExperiedTime"].Value.ToString();
                if(row.Cells["Count"].Value!=null)
                CountText.Text = row.Cells["Count"].Value.ToString();

                string type = row.Cells["Supplier_Name"].Value.ToString();
                UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(type);
                string item = row.Cells["StoreItem_Name"].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(item);
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
            ItemShipment shipment = new ItemShipment();
            ClearDefaults();
            getDate(shipment);

            if (DataValidation())
            {
                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(shipment);

                    if (flag)
                    {
                        MessageBox.Show(null, "Shipment inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    shipment.ID = int.Parse(IdText.Text);
                    shipment.Count = int.Parse(CountText.Text);
                    bool flag = controller.Update(shipment);

                    if (flag)
                    {
                        MessageBox.Show(null, "Shipment  updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getDate(ItemShipment shipment)
        {
            shipment.ArrivalTime =dateTimePicker1.Value.Date;
            shipment.ExperiedTime = dateTimePicker2.Value.Date;
            shipment.StoreItem = context.StoreItems.Find(comboBox1.SelectedValue);
            shipment.Supplier = context.Suppliers.Find(UTypeCombo.SelectedValue);
            shipment.Count = int.Parse(CountText.Text);
        }

        private bool DataValidation()
        {
            bool flag = validateCount();              

            return flag;
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
            else if (textBox.Name == "UsernameText")
            {
                DefaultText(textBox, "Enter username", true);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //refresh table
            dataGrid.DataSource = controller.ViewAll();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            validateCount();
        }

        private bool validateCount()
        {
            string input = CountText.Text.Trim();

            if (input != "Count" && !count.IsMatch(input))
            {
                CountLbl.Text = "Invalid count";
                CountLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                CountLbl.Text = "Count";
                CountLbl.ForeColor = Color.Black;
                return true;
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
                MessageBox.Show(null, "shipment deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validateUserType()
        {
            int selected = UTypeCombo.SelectedIndex;
            int selctedItem = comboBox1.SelectedIndex;
            if (selected == -1)
            {
                SupplierLbl.Text = "Select supplier";
                SupplierLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                SupplierLbl.Text = "Supplier";
                SupplierLbl.ForeColor = Color.Black;
                return true;
            }
            if (selctedItem == -1)
            {
                StoreItemLabel1.Text = "Select item";
                StoreItemLabel1.ForeColor = Color.Red;
                return false;
            }
            else
            {
                StoreItemLabel1.Text = "item";
                StoreItemLabel1.ForeColor = Color.Black;
                return true;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}