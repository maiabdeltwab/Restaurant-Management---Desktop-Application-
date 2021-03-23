using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.ViewModel
{
    class CustomerVM
    {
        public int ID { get; set; }

        [DisplayName("Customer name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string Name { get; set; }

        [RegularExpression("^[0-9]{11}$",ErrorMessage = "Invalid Phone Format")]
        public string Phone { get; set; }
    }
}
