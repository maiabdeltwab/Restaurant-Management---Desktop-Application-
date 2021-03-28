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
                                     ID = p.ID,
                                     Name = p.Name,
                                     Address = p.Address
                                 }).ToList();

            return PhoneCustomer;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer customer)
        {
            try
            {
                context.Customers.Add(customer);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public List<CustomerVM> Search(string searchTxt)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer customer)
        {
            try
            {
                Customer editedcustomer = context.Customers.Find(customer.ID);

                //editedcustomer.ID = customer.ID;
                editedcustomer.Name = customer.Name;
                //editedcustomer.Phone = customer.Phone;
                editedcustomer.Address = customer.Address;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<CustomerVM> ViewAll()
        {
            throw new NotImplementedException();
        }
    }
}