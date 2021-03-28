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
    internal class UserVM
    {
        public int ID { get; set; }

        [DisplayName("First name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string FristName { get; set; }

        [DisplayName("Last name")]
        [RegularExpression("^[A-Za-z -]{3,}$", ErrorMessage = "Please enter a valid name format")]
        public string LastName { get; set; }

        [RegularExpression(@"^([a-z0-9]|[-._](?![-._])){3,}$", ErrorMessage = "Invalid username format")]
        public string Username { get; set; }

        [RegularExpression(@"/^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [DisplayName("Role")]
        public string TypeName { get; set; }

        public string Password { get; set; }
    }
}