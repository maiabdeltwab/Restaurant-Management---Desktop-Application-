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
    public partial class ItemDailyNeedForm : Form
    {
        private readonly StoreItemController controller = new StoreItemController();
        private readonly RestaurantEntities context = StoreItemController.context;


        public ItemDailyNeedForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManagementDataSet.UserType' table. You can move, or remove it, as needed.
       var result= controller.ViewDailyConsumption(dateTimePicker1.Value.Date);
            edited(result);
            dataGrid.DataSource = result;        }

        private void DefaultText(dynamic textBox, string defaultText, bool remove)
        {
          
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
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
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
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search(sender, e);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }      
        private void LNameText_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void formText_Enter(object sender, EventArgs e)
        {
            dynamic textBox = sender;
            
        }

        private void edited(List<ItemDailyNeedVM> list)
        {
            foreach (var item in list)
            {
                item.CurrentCount -=(int) item.Count;
                if (item.RequiredCount - item.CurrentCount > 0)
                    item.needed = item.RequiredCount - item.CurrentCount;
                else
                    item.needed = 0;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //refresh table
           var result= controller.ViewDailyConsumption(dateTimePicker1.Value.Date);
            edited(result);
            dataGrid.DataSource = result;
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var result= controller.ViewDailyConsumption(dateTimePicker1.Value.Date);
            edited(result);
            dataGrid.DataSource = result;        

        }
    }
}