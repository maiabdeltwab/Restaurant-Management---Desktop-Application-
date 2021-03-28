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
    internal class StoreItemTypeVM
    {
        public int ID { get; set; }

        [DisplayName("Name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string Name { get; set; }
    }
}