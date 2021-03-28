using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class SupplierController : ICRUD<Supplier, SupplierVM>
    {
        public static RestaurantEntities context;

        static SupplierController()
        {
            context = new RestaurantEntities();
        }

        public List<SupplierVM> ViewAll()
        {
            var suppliers = (from s in context.Suppliers
                             select new SupplierVM
                             {
                                 ID = s.ID,
                                 Name = s.Name,
                                 Email = s.Email,
                                 Phone = s.Phone
                             }).ToList();

            return suppliers;
        }

        public List<SupplierVM> Search(string searchTxt)
        {
            List<SupplierVM> suppliers = new List<SupplierVM>();

            try
            {
                int.TryParse(searchTxt, out int id);

                suppliers.AddRange((from s in context.Suppliers
                                    where (s.Name.Contains(searchTxt)
                                    || s.Email.Contains(searchTxt)
                                    || s.Phone.Contains(searchTxt)
                                    || s.ID == id)
                                    select new SupplierVM
                                    {
                                        ID = s.ID,
                                        Name = s.Name,
                                        Email = s.Email,
                                        Phone = s.Phone
                                    }).ToList());
            }
            catch { }
            return suppliers;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Suppliers.Remove(context.Suppliers.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Supplier supplier)
        {
            try
            {
                Supplier editedSuppllier = context.Suppliers.Find(supplier.ID);

                editedSuppllier.Name = supplier.Name;
                editedSuppllier.Email = supplier.Email;
                editedSuppllier.Phone = supplier.Phone;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(Supplier supplier)
        {
            try
            {
                context.Suppliers.Add(supplier);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}