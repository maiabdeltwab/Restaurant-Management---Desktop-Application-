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
    internal class StoreItemVM
    {
        public int ID { get; set; }

        [DisplayName("Name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string Name { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid Price format")]
        public Nullable<decimal> Price { get; set; }

        [DisplayName("Current")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid current count format")]
        public Nullable<int> CurrentCount { get; set; }

        [DisplayName("Required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid Requird count format")]
        public Nullable<int> RequiredCount { get; set; }

        //[RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid Quantity format")]
        //public Nullable<decimal> Quantity { get; set; }

        [DisplayName("Type")]
        public string TypeName { get; set; }
    }
}