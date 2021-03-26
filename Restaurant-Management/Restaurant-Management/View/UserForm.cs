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
    public partial class UserForm : Form
    {
        private readonly UserController controller = new UserController();
        private readonly RestaurantEntities context = UserController.context;

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.restaurantManagementDataSet.UserType);

            dataGrid.DataSource = controller.ViewAll();

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

            UsernameText.Text = "Enter username";
            FNameText.Text = "Enter first name";
            LNameText.Text = "Enter last name";
            EmailText.Text = "Enter email";
            IdText.Text = "ID";
            PasswordText.Text = "Enter password";
            UTypeCombo.SelectedIndex = -1;
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
            getDate(user);

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
                    MessageBox.Show(null, "This phone number Already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LNameText_TextChanged(object sender, EventArgs e)
        {
            Regex nameReg = new Regex("^[A-Za-z -]{3,}$");

            string input = LNameText.Text.Trim();
            if (!nameReg.IsMatch(input))
            {
                LNameLbl.Text = "Invalid Name";
                LNameLbl.ForeColor = Color.Red;
            }
            else
            {
                LNameLbl.Text = "Last name";
                LNameLbl.ForeColor = Color.Black;
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
            Regex usernameReg = new Regex("^([a-z0-9]|[-._](?![-._])){3,}$");

            string input = UsernameText.Text.Trim();

            if (input != "Enter username" && !usernameReg.IsMatch(input))
            {
                UsernameLbl.Text = "Invalid username";
                UsernameLbl.ForeColor = Color.Red;
            }
            else
            {
                UsernameLbl.Text = "Username";
                UsernameLbl.ForeColor = Color.Black;
            }
        }

        private void FNameText_TextChanged(object sender, EventArgs e)
        {
            Regex nameReg = new Regex("^[A-Za-z -]{3,}$");

            string input = FNameText.Text.Trim();
            if (!nameReg.IsMatch(input))
            {
                FNameLbl.Text = "Invalid Name";
                FNameLbl.ForeColor = Color.Red;
            }
            else
            {
                FNameLbl.Text = "First name";
                FNameLbl.ForeColor = Color.Black;
            }
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            Regex emailReg = new Regex("^[\\w\\-\\.\\+]+\\@[a-zA-Z0-9\\.\\-]+\\.[a-zA-z0-9]{2,4}$");

            string input = EmailText.Text.Trim();

            if (input != "Enter email" && !emailReg.IsMatch(input))
            {
                EmailLbl.Text = "Invalid Email";
                EmailLbl.ForeColor = Color.Red;
            }
            else
            {
                EmailLbl.Text = "Email";
                EmailLbl.ForeColor = Color.Black;
            }
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            if (PasswordText.Text != "Enter password" && PasswordText.Text.Length < 6)
            {
                PasswordLbl.Text = "Password length must at least 6 chars";
                PasswordLbl.ForeColor = Color.Red;
            }
            else
            {
                PasswordLbl.Text = "Password";
                PasswordLbl.ForeColor = Color.Black;
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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}