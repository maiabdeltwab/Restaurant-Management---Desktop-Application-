using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class DeliveryController : ICRUD<Customer, CustomerVM>
    {
        public static RestaurantEntities context;

        public DeliveryController()
        {
            context = new RestaurantEntities();
        }

        public List<CustomerVM> PhoneSearch(string searchTxt)
        {
            var PhoneCustomer = (from p in context.Customers
                                 where p.Phone == searchTxt
                                 select new CustomerVM
                                 {
                                     Name = p.Name,
                                     Address = p.Address
                                 }).ToList();

            return PhoneCustomer;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer user)
        {
            throw new NotImplementedException();
        }

        public List<CustomerVM> Search(string searchTxt)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer user)
        {
            throw new NotImplementedException();
        }

        public List<CustomerVM> ViewAll()
        {
            throw new NotImplementedException();
        }
    }
}