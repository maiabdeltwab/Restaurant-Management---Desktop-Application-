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

namespace Restaurant_Management
{
    public partial class Slider2 : UserControl
    { 
        private readonly MenuItemController controller = new MenuItemController();
        private readonly RestaurantEntities context = MenuItemController.context;
        public Slider2()
        {
            InitializeComponent();
        }

        private void Slider2_Load(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(MenuItemName1);
            labels.Add(MenuItemName2);
            labels.Add(MenuItemName3);
            labels.Add(MenuItemName4);
            labels.Add(MenuItemName5);
            labels.Add(MenuItemName6);
            labels.Add(MenuItemName7);
            labels.Add(MenuItemName8);
            var MenuitmName = (from Name in context.MenuItems
                               select Name.Name).ToList();
            if (labels.Count > MenuitmName.Count)
            {
                for (int i = 0; i < MenuitmName.Count; i++)
                {
                    if (i >= 0 && i < 8)
                    {
                        continue;
                    }
                    labels[i].Text = MenuitmName[i];
                }
            }
            else
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    labels[i].Text = MenuitmName[i];
                }
            }
        }
      
       
        int x = 0;
        public void Increase(Label label)
        {
            label.Text = (++x).ToString();
        }
        public void Decrease(Label label)
        {
            if (x > 0) { label.Text = (--x).ToString(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Increase(amount1);
        }

        private void btn1decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount1);
        }

        private void btn2increase_Click(object sender, EventArgs e)
        {
            Increase(amount2);
        }

        private void btn3increase_Click(object sender, EventArgs e)
        {
            Increase(amount3);
        }

        private void MenuItemName4_Click(object sender, EventArgs e)
        {

        }

        private void btn5increase_Click(object sender, EventArgs e)
        {
            Increase(amount5);
        }

        private void btn6increase_Click(object sender, EventArgs e)
        {
            Increase(amount6);
        }

        private void btn7increase_Click(object sender, EventArgs e)
        {
            Increase(amount7);
        }

        private void btn8increase_Click(object sender, EventArgs e)
        {
            Increase(amount8);
        }

        private void btn2decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount2);
        }

        private void btn3decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount3);
        }

        private void btn4decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount4);
        }

        private void btn5decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount5);
        }

        private void btn6decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount6);
        }

        private void btn7decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount7);
        }

        private void btn8decrease_Click(object sender, EventArgs e)
        {
            Decrease(amount8);
        }

        private void btn4increase_Click(object sender, EventArgs e)
        {
            Increase(amount4);
        }
    }
}
