using Restaurant_Management.Controllers;
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
    public partial class OrderItems : Form
    {
        public int id { get; set; }
        private readonly OrderController controller = new OrderController();
        private readonly RestaurantEntities context = OrderController.context;
        public OrderItems(int id)
        {
            this.id = id;   
            InitializeComponent();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGrid.DataSource = controller().inse;
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.DisplayItems(id);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
