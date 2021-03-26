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
    public partial class UserForm : Form
    {
        private readonly UserController controller = new UserController();
        private readonly RestaurantEntities context = UserController.context;

        private readonly UserType userType = null;

        private readonly Regex usernameReg = new Regex("^([a-z0-9]|[-._](?![-._])){3,}$");
        private readonly Regex nameReg = new Regex("^[A-Za-z -]{3,}$");
        private readonly Regex emailReg = new Regex("^[\\w\\-\\.\\+]+\\@[a-zA-Z0-9\\.\\-]+\\.[a-zA-z0-9]{2,4}$");

        public UserForm(UserType userType = null)
        {
            InitializeComponent();

            this.userType = userType;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.restaurantManagementDataSet.UserType);

            IdText.Enabled = false;
            ClearData();

            if (userType != null)
            {
                dataGrid.DataSource = controller.ViewUsersType(userType);
                UTypeCombo.SelectedIndex = UTypeCombo.FindStringExact(userType.Name);
                searchTextBox.Text = userType.Name;
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

            UsernameText.Text = "Enter username";
            FNameText.Text = "Enter first name";
            LNameText.Text = "Enter last name";
            EmailText.Text = "Enter email";
            IdText.Text = "ID";
            PasswordText.Text = "Enter password";
            UTypeCombo.SelectedIndex = -1;
            UTypeCombo.Text = "Select a type";

            saveBtn.Text = "Create";
            groupBox.Text = "Create user";
            deleteBtn.Visible = false;
        }

        public void ClearDefaults()
        {
            DefaultText(UsernameText, "Enter username", true);
            DefaultText(FNameText, "Enter first name", true);
            DefaultText(LNameText, "Enter last name", true);
            DefaultText(EmailText, "Enter email", true);
            DefaultText(PasswordText, "Enter password", true);
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                UsernameText.Text = row.Cells["Username"].Value.ToString();
                EmailText.Text = row.Cells["Email"].Value.ToString();
                FNameText.Text = row.Cells["FristName"].Value.ToString();
                LNameText.Text = row.Cells["LastName"].Value.ToString();

                string type = row.Cells["TypeName"].Value.ToString();
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
            User user = new User();
            ClearDefaults();
            getDate(user);

            if (DataValidation())
            {
                if (saveBtn.Text == "Create")
                {
                    bool flag = controller.Insert(user);

                    if (flag)
                    {
                        MessageBox.Show(null, "User inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh table
                        dataGrid.DataSource = controller.ViewAll();
                    }
                    else
                        MessageBox.Show(null, "Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user.ID = int.Parse(IdText.Text);

                    bool flag = controller.Update(user);

                    if (flag)
                    {
                        MessageBox.Show(null, "User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void getDate(User user)
        {
            user.Username = UsernameText.Text;
            user.FristName = FNameText.Text;
            user.LastName = LNameText.Text;
            user.Email = EmailText.Text;
            user.UserType = context.UserTypes.Find(UTypeCombo.SelectedValue);
            user.Password = PasswordText.Text;
        }

        private bool DataValidation()
        {
            bool flag = validateUserType() && validateLName() && validateFName() && validateUsername()
                && validateEmail() && validatePassword();

            return flag;
        }

        private void LNameText_TextChanged(object sender, EventArgs e)
        {
            validateLName();
        }

        private bool validateLName()
        {
            string input = LNameText.Text.Trim();
            if (!nameReg.IsMatch(input))
            {
                LNameLbl.Text = "Invalid Name";
                LNameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                LNameLbl.Text = "Last name";
                LNameLbl.ForeColor = Color.Black;
                return true;
            }
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
            validateUsername();
        }

        private bool validateUsername()
        {
            string input = UsernameText.Text.Trim();

            if (input != "Enter username" && !usernameReg.IsMatch(input))
            {
                UsernameLbl.Text = "Invalid username";
                UsernameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                UsernameLbl.Text = "Username";
                UsernameLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void FNameText_TextChanged(object sender, EventArgs e)
        {
            validateFName();
        }

        private bool validateFName()
        {
            string input = FNameText.Text.Trim();
            if (!nameReg.IsMatch(input))
            {
                FNameLbl.Text = "Invalid Name";
                FNameLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                FNameLbl.Text = "First name";
                FNameLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            validateEmail();
        }

        private bool validateEmail()
        {
            string input = EmailText.Text.Trim();

            if (input != "Enter email" && !emailReg.IsMatch(input))
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

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            validatePassword();
        }

        private bool validatePassword()
        {
            if (PasswordText.Text != "Enter password" && PasswordText.Text.Length < 6)
            {
                PasswordLbl.Text = "Password length must at least 6 chars";
                PasswordLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                PasswordLbl.Text = "Password";
                PasswordLbl.ForeColor = Color.Black;
                return true;
            }
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

        private bool validateUserType()
        {
            int selected = UTypeCombo.SelectedIndex;

            if (selected == -1)
            {
                UTypeLbl.Text = "Select Role";
                UTypeLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                UTypeLbl.Text = "User Role";
                UTypeLbl.ForeColor = Color.Black;
                return true;
            }
        }
    }
}