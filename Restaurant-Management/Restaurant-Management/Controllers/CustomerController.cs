using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class CustomerController : ICRUD<Customer, CustomerVM>
    {
        public static RestaurantEntities context;

        static CustomerController()
        {
            context = new RestaurantEntities();
        }

        public List<CustomerVM> ViewAll()
        {
            var customers = (from C in context.Customers
                             select new CustomerVM
                             {
                                 ID = C.ID,
                                 Name = C.Name,
                                 Phone = C.Phone,
                                 Address = C.Address
                             }).ToList();

            return customers;
        }

        public List<CustomerVM> Search(string searchTxt)
        {
            List<CustomerVM> customers = new List<CustomerVM>();
            customers.AddRange((from C in context.Customers
                                where (C.Name.Contains(searchTxt)
                                || C.Phone.Contains(searchTxt)
                                || C.Address.Contains(searchTxt))
                                select new CustomerVM
                                {
                                    ID = C.ID,
                                    Name = C.Name,
                                    Phone = C.Phone,
                                    Address = C.Address
                                }).ToList());
            try
            {
                int id = int.Parse(searchTxt);
                customers.AddRange((from C in context.Customers
                                    where C.ID == id
                                    select new CustomerVM
                                    {
                                        ID = C.ID,
                                        Name = C.Name,
                                        Phone = C.Phone,
                                        Address = C.Address
                                    }).ToList());
            }
            catch { }
            return customers;
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

        public bool Delete(int id)
        {
            try
            {
                context.Customers.Remove(context.Customers.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                Customer editedcustomer = context.Customers.Find(customer.ID);

                editedcustomer.ID = customer.ID;
                editedcustomer.Name = customer.Name;
                editedcustomer.Phone = customer.Phone;
                editedcustomer.Address = customer.Address;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static implicit operator CustomerController(UserController v)
        {
            throw new NotImplementedException();
        }
    }
}