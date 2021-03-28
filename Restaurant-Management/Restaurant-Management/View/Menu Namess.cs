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
    public partial class Menu_Namess : Form
    {
        public Menu_Namess()
        {
            InitializeComponent();
        }
        int[] MenuID=new int[2];

        private readonly MenuController controller = new MenuController();
        private readonly RestaurantEntities context = MenuController.context;
        private void Menu_Namess_Load(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(MenuType1);
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            
             var Menuname = (from menu in context.Menus
                             select menu.Name).ToList();
            if (labels.Count > Menuname.Count)
            {

                for (int i = 0; i < Menuname.Count; i++)
                {

                    labels[i].Text = Menuname[i];
                }
            }
            else
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    labels[i].Text = Menuname[i];
                }
            }
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);

            var Menupic = (from Pic in context.Menus
                            select new { Pic.ImagePath ,Pic.ID}).ToList();
            
            if (pictureBoxes.Count > Menupic.Count)
            {
                for (int i = 0; i < Menupic.Count; i++)
                {
                    
                    if (Menupic[i].ImagePath == null)
                    {
                        int x = Menupic[i].ID;
                        MenuID[i] = x;
                        pictureBoxes[i].Image = Image.FromFile(@"C:\Users\Elamen Soft\Documents\GitHub\Restaurant-Management-Desktop\Restaurant-Management\Restaurant-Management\View\images\download (2).jfif");
                    }
                    else
                    {
                        
                        pictureBoxes[i].Image = Image.FromFile(Menupic[i].ImagePath);
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < Menupic.Count; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(Menupic[i].ImagePath);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            UserControl1 userControl1 = new UserControl1(MenuID[0]);
            UserControl2 userControl2 = new UserControl2(MenuID[0]);
            MenuitemSlider menuitem = new MenuitemSlider(MenuID[0]);
            this.Hide();
            menuitem.Show();
        }
    }
}
