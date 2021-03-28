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
    internal class ItemDailyNeedVM
    {
        [DisplayName("Store Item ID")]
        public int ID { get; set; }

        [DisplayName("Store Item name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string Name { get; set; }

        [DisplayName("Current Count")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid current count format")]
        public Nullable<int> CurrentCount { get; set; }

        [DisplayName("Required count")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid Requird count format")]
        public Nullable<int> RequiredCount { get; set; }

        [DisplayName("Consumption count")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid Requird count format")]
        public Nullable<decimal> Count { get; set; }
        public Nullable<decimal> needed { get; set; }

        public Nullable<System.DateTime> Date { get; set; }
    }
}