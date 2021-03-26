using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.ViewModel
{
   internal class MenuItemVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Describtion { get; set; }

        [DisplayName("MenuName")]
        public string MenuName { get; set; }
    }
}
