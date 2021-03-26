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

namespace Restaurant_Management.View
{
    public partial class OrdersForm : Form
    {
        private readonly OrderController controller = new OrderController();
        private readonly RestaurantEntities context = OrderController.context;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.OrderType' table. You can move, or remove it, as needed.
            this.orderTypeTableAdapter.Fill(this.restaurantManagementDataSet.OrderType);
            //this.customerTableAdapter.Fill(this.restaurantManagementDataSet.Customer);
            dataGrid.DataSource = controller.ViewAll();

            OTypeCombo.SelectedIndex = -1;
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

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClearData();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                //groupBox.Text = "Update user";
                deleteBtn.Visible = true;
                ShowButton.Visible = true;
                SelectRow();
            }
            else
            {
                //groupBox.Text = "Create user";
                deleteBtn.Visible = false;
                ShowButton.Visible = true;
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
            IdText.Text = "Order ID";
            PriceText.Text = "Order Price";
            DateText.Text = "Order Date";
            OTypeCombo.SelectedIndex = -1;
            CustomerText.Text = "Customer Name";

            deleteBtn.Visible = false;
            ShowButton.Visible = false;
        }

        private void SelectRow()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var row = dataGrid.SelectedRows[0];

                IdText.Text = row.Cells["ID"].Value.ToString();
                PriceText.Text = row.Cells["Price"].Value.ToString();
                DateText.Text = row.Cells["Date"].Value.ToString();
                //OTypeCombo.Text = row.Cells["OrderType"].Value.ToString();
                CustomerText.Text = row.Cells["CustomerName"].Value.ToString();

                string type = row.Cells["OrderType"].Value.ToString();
                OTypeCombo.SelectedIndex = OTypeCombo.FindStringExact(type);

                //saveBtn.Text = "Update";
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //refresh table
            dataGrid.DataSource = controller.ViewAll();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();

            bool isnumeric = int.TryParse(IdText.Text, out int n);
            if (isnumeric)
            {
                orderItem.ID = int.Parse(IdText.Text);
                int id = orderItem.ID;
                Form formBackground = new Form();
                using (OrderItemsForm orderItems = new OrderItemsForm(id))
                {
                    //dataGrid.DataSource = controller.DisplayItems();
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    orderItems.Owner = formBackground;
                    orderItems.ShowDialog();
                    formBackground.Dispose();
                }
            }
            else
            {
                MessageBox.Show(null, "Check Order to Display items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    formBackground.Dispose();

            //}
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
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

        //private void saveBtn_Click(object sender, EventArgs e)
        //{
        //    User user = new User();
        //    getDate(user);

        //    if (saveBtn.Text == "Create")
        //    {
        //        bool flag = controller.Insert(user);

        //        if (flag)
        //        {
        //            MessageBox.Show(null, "User inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //refresh table
        //            dataGrid.DataSource = controller.ViewAll();
        //        }
        //        else
        //            MessageBox.Show(null, "This phone number Already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        user.ID = int.Parse(IdText.Text);

        //        bool flag = controller.Update(user);

        //        if (flag)
        //        {
        //            MessageBox.Show(null, "User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //refresh table
        //            dataGrid.DataSource = controller.ViewAll();
        //        }
        //        else
        //            MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void getDate(User user)
        //{
        //    user.Username = UsernameText.Text;
        //    user.FristName = FNameText.Text;
        //    user.LastName = LNameText.Text;
        //    user.Email = EmailText.Text;
        //    user.UserType = context.UserTypes.Find(UTypeCombo.SelectedValue);
        //    user.Password = PasswordText.Text;
        //}
    }
}