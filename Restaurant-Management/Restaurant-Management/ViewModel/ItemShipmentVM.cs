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

        [DisplayName("Item")]
        public string StoreItem_Name { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "Please enter a valid Count format")]
        public int? Count { get; set; }

        [DisplayName("Supplier")]
        public string Supplier_Name { get; set; }

        [DisplayName("Arrived at")]
        public DateTime? ArrivalTime { get; set; }

        [DisplayName("Experied in")]
        public DateTime? ExperiedTime { get; set; }
    }
}