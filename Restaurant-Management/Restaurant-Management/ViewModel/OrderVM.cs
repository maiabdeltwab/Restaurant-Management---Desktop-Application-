using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.ViewModel
{
    internal class OrderVM
    {
        public int ID { get; set; }

        [DisplayName("Price")]
        [Required]
        public Nullable<decimal> Price { get; set; }

        [DisplayName("Date")]
        [Required]
        public Nullable<System.DateTime> Date { get; set; }

        [DisplayName("Type")]
        [Required]
        public string OrderType { get; set; }

        [DisplayName("Customer Name")]
        [Required]
        public string CustomerName { get; set; }

        //public string Menuitem { get; set; }
        //public int? Count { get; set; }
    }
}