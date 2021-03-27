using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.ViewModel
{
    internal class ItemShipmentVM
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> ExperiedTime { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "Please enter a valid Count format")]
        public Nullable<int> Count { get; set; }
        [DisplayName("Supplier Name")]
        public String Supplier_Name { get; set; }
        [DisplayName("Item Name")]
        public String StoreItem_Name { get; set; }
    }
}