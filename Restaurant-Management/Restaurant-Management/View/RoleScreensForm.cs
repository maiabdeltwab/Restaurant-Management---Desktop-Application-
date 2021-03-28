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
    public partial class RoleScreensForm : Form
    {
        private UserType Role;
        private UserTypeController controller = new UserTypeController();
        private RestaurantEntities context = new RestaurantEntities();
        private List<Model.Screen> screens = new List<Model.Screen>();

        public RoleScreensForm(UserType Role)
        {
            InitializeComponent();

            this.Role = Role;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            BackToRole();
        }

        private void BackToRole()
        {
            UserTypeForm objForm = new UserTypeForm
            {
                TopLevel = false
            };
            this.Controls.Clear();
            this.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void allUserList_CheckedChanged(object sender, EventArgs e)
        {
            bool select = allUserList.Checked;

            for (int i = 0; i < userList.Items.Count; i++)
            {
                userList.SetItemChecked(i, select);
            }
        }

        private void allMenuList_CheckedChanged(object sender, EventArgs e)
        {
            bool select = allMenuList.Checked;

            for (int i = 0; i < menuList.Items.Count; i++)
            {
                menuList.SetItemChecked(i, select);
            }
        }

        private void allCustomerList_CheckedChanged(object sender, EventArgs e)
        {
            bool select = allCustomerList.Checked;

            for (int i = 0; i < customerList.Items.Count; i++)
            {
                customerList.SetItemChecked(i, select);
            }
        }

        private void allStoreList_CheckedChanged(object sender, EventArgs e)
        {
            bool select = allStoreList.Checked;

            for (int i = 0; i < storeList.Items.Count; i++)
            {
                storeList.SetItemChecked(i, select);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in userList.SelectedItems)
            {
                string name = userList.GetItemText(item).Trim();
                Model.Screen screen = context.Screens.Where(s => s.Name == name).FirstOrDefault();
                screens.Add(screen);
            }

            foreach (var item in storeList.SelectedItems)
            {
                string name = storeList.GetItemText(item);
                Model.Screen screen = context.Screens.Where(s => s.Name == name).FirstOrDefault();
                screens.Add(screen);
            }

            foreach (var item in menuList.SelectedItems)
            {
                string name = menuList.GetItemText(item);
                Model.Screen screen = context.Screens.Where(s => s.Name == name).FirstOrDefault();
                screens.Add(screen);
            }

            foreach (var item in customerList.SelectedItems)
            {
                string name = customerList.GetItemText(item);
                Model.Screen screen = context.Screens.Where(s => s.Name == name).FirstOrDefault();
                screens.Add(screen);
            }

            if (controller.AssignScreens(screens, Role))
            {
                MessageBox.Show(null, "User Privileges assigned successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Something went wrong", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RoleScreensForm_Load(object sender, EventArgs e)
        {
            List<Model.Screen> screens = new List<Model.Screen>();

            foreach (var screen in screens)
            {
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}