using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class OrderController : ICRUD<Order, OrderVM>
    {
        public static RestaurantEntities context;

        static OrderController()
        {
            context = new RestaurantEntities();
        }

        public List<OrderVM> ViewAll()
        {
            var orders = (from o in context.Orders
                          select new OrderVM
                          {
                              ID = o.ID,
                              Price = o.Price,
                              Date = o.Date,
                              OrderType = o.OrderType.Name,
                              CustomerName = o.Customer.Name,
                          }).ToList();

            return orders;
        }

        public List<OrderItemVM> DisplayItems(int id)
        {
            var items = (from i in context.OrderItems
                         where i.Order_id == id
                         select new OrderItemVM
                         {
                             Menuitem = i.MenuItem.Name,
                             Count = i.Count,
                         }
                         ).ToList();
            return items;
        }

        public List<OrderVM> Search(string searchTxt)
        {
            List<OrderVM> orders = new List<OrderVM>();
            orders.AddRange((from o in context.Orders
                             where (
                             //o.Price.Equals(searchTxt)
                             //|| o.Date.Equals(searchTxt)
                             //||

                             o.OrderType.Name.Contains(searchTxt)
                             || o.Customer.Name.Contains(searchTxt))
                             select new OrderVM
                             {
                                 ID = o.ID,
                                 Price = o.Price,
                                 Date = o.Date,
                                 OrderType = o.OrderType.Name,
                                 CustomerName = o.Customer.Name,
                             }).ToList());
            try
            {
                int id = int.Parse(searchTxt);
                orders.AddRange((from o in context.Orders
                                 where o.ID == id
                                 select new OrderVM
                                 {
                                     ID = o.ID,
                                     Price = o.Price,
                                     Date = o.Date,
                                     OrderType = o.OrderType.Name,
                                     CustomerName = o.Customer.Name,
                                 }).ToList());
            }
            catch { }
            return orders;
        }

        public bool Delete(int id)
        {
            try
            {
                var query = (from i in context.OrderItems
                             where i.Order_id == id
                             select i.ID).ToList();
                foreach (var item in query)
                {
                    context.OrderItems.Remove(context.OrderItems.Find(item));
                }
                //context.OrderItems.Remove(context.OrderItems.Find(id));
                context.Orders.Remove(context.Orders.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(Order order)
        {
            try
            {
                context.Orders.Add(order);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Order order)
        {
            try
            {
                Order editedOrder = context.Orders.Find(order.ID);

                editedOrder.ID = order.ID;
                editedOrder.Price = order.Price;
                editedOrder.Date = order.Date;
                editedOrder.OrderType = order.OrderType;
                editedOrder.Customer = order.Customer;

                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}