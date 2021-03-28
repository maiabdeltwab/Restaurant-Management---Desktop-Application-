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
    public partial class PullAmountForm : Form
    {
        private StoreItem storeItem;

        public PullAmountForm(StoreItem storeItem)
        {
            InitializeComponent();
            this.storeItem = storeItem;
        }

        private void CurrentAmountText_TextChanged(object sender, EventArgs e)
        {
            valid();
        }

        private bool valid()
        {
            string input = AmountText.Text.Trim();

            if (!Validation.isInteger(input))
            {
                AmountLbl.Text = "Count must be an integer";
                AmountLbl.ForeColor = Color.Red;
                return false;
            }
            else if (Validation.isInteger(input) && int.Parse(input) > storeItem.CurrentCount)
            {
                AmountLbl.Text = "There is no enough amount";
                AmountLbl.ForeColor = Color.Red;
                return false;
            }
            else
            {
                AmountLbl.Text = "Count";
                AmountLbl.ForeColor = Color.Black;
                return true;
            }
        }

        private void PullAmountForm_Load(object sender, EventArgs e)
        {
        }

        private void PullBtn_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                int input = int.Parse(AmountText.Text.Trim());

                RestaurantEntities context = StoreItemController.context;

                context.StoreConsumptions.Add(new StoreConsumption
                {
                    StoreItem_id = storeItem.ID,
                    Count = input,
                    Date = DateTime.Now
                });

                StoreItem item = context.StoreItems.Find(storeItem.ID);
                item.CurrentCount -= input;

                context.SaveChanges();
                this.Close();
            }
        }
    }
}