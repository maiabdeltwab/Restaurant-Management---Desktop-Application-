using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class MenuItemController : ICRUD<MenuItem, MenuItemVM>
    {
        public static RestaurantEntities context;

        static MenuItemController()
        {
            context = new RestaurantEntities();
        }

        public List<MenuItemVM> ViewAll()
        {
            var menuItems = (from u in context.MenuItems
                             select new MenuItemVM
                             {
                                 ID = u.ID,
                                 Name = u.Name,
                                 Price = u.Price,
                                 Describtion = u.Describtion,
                                 MenuName = u.Menu.Name,
                             }).ToList();

            return menuItems;
        }

        public List<MenuItemVM> Search(string searchTxt)
        {
            List<MenuItemVM> menuItems = new List<MenuItemVM>();

            menuItems.AddRange((from u in context.MenuItems
                                where (u.Price.ToString().Contains(searchTxt)
                                || u.Name.Contains(searchTxt)
                                || u.Describtion.Contains(searchTxt)
                                || u.Menu.Name.Contains(searchTxt))
                                select new MenuItemVM
                                {
                                    ID = u.ID,
                                    Name = u.Name,
                                    Price = u.Price,
                                    Describtion = u.Describtion,
                                    MenuName = u.Menu.Name
                                }).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                menuItems.AddRange((from u in context.MenuItems
                                    where u.ID == id
                                    select new MenuItemVM
                                    {
                                        ID = u.ID,
                                        Name = u.Name,
                                        Price = u.Price,
                                        Describtion = u.Describtion,
                                        MenuName = u.Menu.Name
                                    }).ToList());
            }
            catch { }
            return menuItems;
        }

        public bool Delete(int id)
        {
            try
            {
                context.MenuItems.Remove(context.MenuItems.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(MenuItem menuItem)
        {
            try
            {
                MenuItem editedItem = context.MenuItems.Find(menuItem.ID);
                editedItem.ID = menuItem.ID;
                editedItem.Name = menuItem.Name;
                editedItem.Price = menuItem.Price;
                editedItem.Describtion = menuItem.Describtion;
                editedItem.Menu = menuItem.Menu;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(MenuItem menuItem)
        {
            try
            {
                context.MenuItems.Add(menuItem);

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