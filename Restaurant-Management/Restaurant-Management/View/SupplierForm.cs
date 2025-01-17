﻿using Restaurant_Management.Controllers;
using Restaurant_Management.Model;
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
    public partial class SupplierForm : Form
    {
        private readonly SupplierController controller = new SupplierController();
        private readonly RestaurantEntities context = SupplierController.context;

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void Supplier_Form_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.ViewAll();
            dataGrid.Columns["ID"].Width = 70;

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
                groupBox.Text = "Update Supplier";
                deleteBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create Supplier";
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

            SupNameText.Text = "Enter name";
            EmailText.Text = "Enter email";
            phoneText.Text = "Enter phone";
            IdText.Text = "ID";
            saveBtn.Text = "Create";
            groupBox.Text = "Create Supplier";
            deleteBtn.Visible = false;
        }

        private void ClearDefault()
        {
            DefaultText(SupNameText, "Enter name", true);
            DefaultText(phoneText, "Enter phone", true);
            DefaultText(EmailText, "Enter email", true);
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                SupNameText.Text = row.Cells["Name"].Value.ToString();
                EmailText.Text = row.Cells["Email"].Value.ToString();
                phoneText.Text = row.Cells["Phone"].Value.ToString();

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
            Supplier supplier = new Supplier();
            ClearDefault();

            if (ValidateData())
            {
                getDate(supplier);

                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(supplier);

                    if (flag)
                    {
                        MessageBox.Show(null, "Supplier inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    supplier.ID = int.Parse(IdText.Text);

                    bool flag = controller.Update(supplier);

                    if (flag)
                    {
                        MessageBox.Show(null, "Supplier updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ValidateData()
        {
            return ValidateName() && ValidateEmail() && ValidatePhone();
        }

        private void getDate(Supplier supplier)
        {
            supplier.Name = SupNameText.Text;
            supplier.Email = EmailText.Text;
            supplier.Phone = phoneText.Text;
        }

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;

            if (textBox.Name == "SupNameText")
            {
                DefaultText(textBox, "Enter name", true);
            }
            else if (textBox.Name == "EmailText")
            {
                DefaultText(textBox, "Enter email", true);
            }
            else if (textBox.Name == "phoneText")
            {
                DefaultText(textBox, "Enter phone", true);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.ViewAll();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private bool ValidateName()
        {
            string input = SupNameText.Text.Trim();

            if (input != "Enter name" && !Validation.IsName(input))
            {
                nameLbl.Text = "Invalid Name";
                nameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                nameLbl.Text = "Supplier Name";
                nameLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private bool ValidateEmail()
        {
            string input = EmailText.Text.Trim();

            if (input != "Enter email" && !Validation.IsEmail(input))
            {
                EmailLbl.Text = "Invalid Email";
                EmailLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                EmailLbl.Text = "Email";
                EmailLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdText.Text);

            if (controller.Delete(id))
            {
                MessageBox.Show(null, "Supplier deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh table
                dataGrid.DataSource = controller.ViewAll();
            }
            else
                MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhone();
        }

        private bool ValidatePhone()
        {
            string input = phoneText.Text.Trim();

            if (input != "Enter phone" && !Validation.IsPhone(input))
            {
                phoneLbl.Text = "Invalid phone number";
                phoneLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                phoneLbl.Text = "Phone";
                phoneLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void dataGrid_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClearData();
        }

        private void searchTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }
    }
}