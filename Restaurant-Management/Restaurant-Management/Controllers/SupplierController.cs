using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    class SupplierController : ICRUD<Supplier, SupplierVM>
    {
        public static RestaurantEntities context;

        static SupplierController()
        {
            context = new RestaurantEntities();
        }

        public List<SupplierVM> ViewAll()
        {
            var suppliers = (from u in context.Suppliers
                             select new SupplierVM
                             {
                                 ID = u.ID,
                                 Name = u.Name,
                                 Email = u.Email,
                                 

                             }).ToList();

            return suppliers;
        }

        public List<SupplierVM> Search(string searchTxt)
        {
            List<SupplierVM> suppliers = new List<SupplierVM>();

            suppliers.AddRange((from u in context.Suppliers
                                where (u.Name.Contains(searchTxt)
                                || u.Email.Contains(searchTxt))
                                select new SupplierVM
                                {
                                    ID = u.ID,
                                    Name = u.Name,
                                    Email = u.Email
                                }).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                suppliers.AddRange((from u in context.Suppliers
                                    where u.ID == id
                                    select new SupplierVM
                                    {
                                        ID = u.ID,
                                        Name = u.Name,
                                        Email = u.Email
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

                editedSuppllier.ID = supplier.ID;
                editedSuppllier.Name = supplier.Name;
                editedSuppllier.Email = supplier.Email;
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

