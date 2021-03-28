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
using MenuItem = Restaurant_Management.Model.MenuItem;

namespace Restaurant_Management.View
{
    public partial class SelectedItemsForm : Form
    {
        decimal totalprice = 0;

        MenuItem item = new MenuItem();
        OrderItem orderItem = new OrderItem();

        private readonly OrderController ordercontroller = new OrderController();
        public static RestaurantEntities context = new RestaurantEntities();
        public SelectedItemsForm()
        {
            InitializeComponent();
        }

        private void SelectedItemsForm_Load(object sender, EventArgs e)
        {
            var query = (from mi in context.MenuItems
                         select new
                         {
                             mi.ID,
                             mi.Name,
                             mi.Price,
                         }).ToList();

            foreach (var item in query)
            {
                int i = 0;
                totalprice += item.Price;
                PriceLbl.Text = totalprice.ToString();
                Label lbl = addLabel(item.Name, item.Price, i);
                flowLayoutPanel1.Controls.Add(lbl);
            }
        }


        Label addLabel(string name, decimal price, int i)
        {
            ++i;

            Label lbl = new Label();

            lbl.Name = "label" + i;
            lbl.Text = name + " :  " + price;
            //lbl.ForeColor = Color.White;
            //lbl.BackColor = Color.FromArgb(254, 179, 1);
            lbl.ForeColor = Color.Black;
            lbl.BackColor = Color.White;
            lbl.Width = 270;
            lbl.Height = 120;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Margin = new Padding(30);
            ++i;
            return lbl;


        }
        
        
      

        private void DelivaryBtn_Click(object sender, EventArgs e)
        {
            totalprice += 10;
            PriceLbl.Text = totalprice.ToString();
            Order order = new Order();
            getDate(order);
            order.OrderType_id = 1;

            bool flag = ordercontroller.Insert(order);
            var query = (from mi in context.MenuItems
                         select new
                         {
                             mi.ID,
                             mi.Name,
                             mi.Price,
                         }).ToList();
            var orderId = (from oi in context.OrderItems
                           orderby oi.Order_id descending
                           select oi.Order_id).FirstOrDefault();
            orderItem.Order_id = orderId + 1;

            foreach (var item in query)
            {
                orderItem.MenuItem_id = item.ID;
                orderItem.Count = 1;
                context.OrderItems.Add(orderItem);
                context.SaveChanges();
            }
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.Show();
            this.Hide();
        }

        private void FoodCourtBtn_Click(object sender, EventArgs e)
        {
            totalprice += (totalprice * 0.1m);
            PriceLbl.Text = totalprice.ToString();
            Order order = new Order();
            getDate(order);
            order.OrderType_id = 2;
            bool flag = ordercontroller.Insert(order);

            if (flag)
            {
                MessageBox.Show(null, "order Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var query = (from mi in context.MenuItems
                         select new
                         {
                             mi.ID,
                             mi.Name,
                             mi.Price,
                         }).ToList();
            var orderId = (from oi in context.OrderItems
                           orderby oi.Order_id descending
                           select oi.Order_id).FirstOrDefault();
            orderItem.Order_id = orderId + 1;
            foreach (var item in query)
            {
                orderItem.MenuItem_id = item.ID;
                orderItem.Count = 1;
                context.OrderItems.Add(orderItem);
                context.SaveChanges();
            }
        }

        private void TakeawayBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            getDate(order);
            order.OrderType_id = 1;

            bool flag = ordercontroller.Insert(order);

            if (flag)
            {
                MessageBox.Show(null, "order Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(null, "Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var query = (from mi in context.MenuItems
                         select new
                         {
                             mi.ID,
                             mi.Name,
                             mi.Price,
                         }).ToList();
            var orderId = (from oi in context.OrderItems
                           orderby oi.Order_id descending
                           select oi.Order_id).FirstOrDefault();
            orderItem.Order_id = orderId + 1;

            foreach (var item in query)
            {
                orderItem.MenuItem_id = item.ID;
                orderItem.Count = 1;
                context.OrderItems.Add(orderItem);
                context.SaveChanges();
            }
        }
        private void getDate(Order order)
        {
            order.Date = DateTime.Now;

            order.Price = totalprice;

        }
    }
}
