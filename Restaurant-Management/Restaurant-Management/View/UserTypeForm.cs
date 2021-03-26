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
    public partial class UserTypeForm : Form
    {
        private UserTypeController controller = new UserTypeController();
        private readonly RestaurantEntities context = UserController.context;
        private Regex nameReg = new Regex("^[A-Za-z -]{3,}$");

        public UserTypeForm()
        {
            InitializeComponent();
        }

        private void UserTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.restaurantManagementDataSet.UserType);

            IdText.Enabled = false;
            ClearData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UserType userType = new UserType();
            getDate(userType);

            if (validateName())
            {
                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(userType);

                    if (flag)
                    {
                        MessageBox.Show(null, "User Type inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    userType.ID = int.Parse(IdText.Text);

                    bool flag = controller.Update(userType);

                    if (flag)
                    {
                        MessageBox.Show(null, "User Type updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void getDate(UserType userType)
        {
            DefaultText(DescriptionText, "Enter description for this type", true);
            DefaultText(NameText, "Enter type name", true);

            userType.Name = NameText.Text;
            userType.Description = DescriptionText.Text;
        }

        private void dataGrid_rowCountChange(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void dataGrid_rowCountChange(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rowCount.Text = $"Results: {dataGrid.Rows.Count} rows";
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                groupBox.Text = "Update user type";
                deleteBtn.Visible = true;
                usersBtn.Visible = true;
                SelectRow();
            }
            else
            {
                groupBox.Text = "Create user type";
                deleteBtn.Visible = false;
                usersBtn.Visible = false;
                ClearData();
            }
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells[0].Value.ToString();
                DescriptionText.Text = row.Cells[2].Value.ToString();
                NameText.Text = row.Cells[1].Value.ToString();

                saveBtn.Text = "Update";
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            dataGrid.ClearSelection();

            NameText.Text = "Enter type name";
            DescriptionText.Text = "Enter description for this type";
            IdText.Text = "ID";
            saveBtn.Text = "Create";
            groupBox.Text = "Create user type";

            deleteBtn.Visible = false;
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClearData();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.ViewAll();
        }

        private void search(object sender, EventArgs e)
        {
            string search = searchTextBox.Text.Trim();
            if (search == "" || search == "What do you want to seach?")
                dataGrid.DataSource = controller.ViewAll();
            else
                dataGrid.DataSource = controller.Search(search);
        }

        private void searchTextBox_MouseEnter(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", true);
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

        private void searchTextBox_MouseHover(object sender, EventArgs e)
        {
            DefaultText(sender, "What do you want to seach?", false);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }

        private void searchBtn_active(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search_active.png");
        }

        private void searchBtn_disactive(object sender, EventArgs e)
        {
            searchBtn.Image = Image.FromFile(App.ImagePath + @"\icon_search.png");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdText.Text);

            int flag = controller.Delete(id);

            while (flag <= 1)
            {
                if (flag == 1)
                {
                    MessageBox.Show(null, "User Type deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh table
                    dataGrid.DataSource = controller.ViewAll();

                    break;
                }
                else if (flag == 0)
                {
                    DialogResult dialogResult = MessageBox.Show(null, "Can't delete this type because there are users assigned to it.\nDo you want to delete them? ",
                        "Can't delete object", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!controller.DeleteUsers(id))
                            flag = -1;
                        flag = controller.Delete(id);
                    }
                    else break;
                }
                else
                {
                    MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
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

        private void NameText_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter type name", true);
        }

        private void DescriptionText_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter description for this type", true);
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }

        private bool validateName()
        {
            string input = NameText.Text.Trim();
            if (!nameReg.IsMatch(input))
            {
                NameLbl.Text = "Invalid Name";
                NameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                NameLbl.Text = "First name";
                NameLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UserType userType = controller.GetUserType(int.Parse(IdText.Text));
            UserForm userForm = new UserForm(userType)
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(userForm);
            userForm.Show();
        }
    }
}