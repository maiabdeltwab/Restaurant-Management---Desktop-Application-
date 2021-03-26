using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    class MenuController : ICRUD<Menu, MenuVM>
    {
        public static RestaurantEntities context;

        static MenuController()
        {
            context = new RestaurantEntities();
        }

        public List<MenuVM> ViewAll()
        {
            var menus = (from M in context.Menus
                         select new MenuVM
                         {
                             ID = M.ID,
                             Name=M.Name,
                           //  TypeName = M.MenuItems.Name,
                         }).ToList();

            return menus;
        }

        public List<MenuVM> Search(string searchTxt)
        {
            List<MenuVM> menus = new List<MenuVM>();

            menus.AddRange((from M in context.Menus
                            where (M.Name.Contains(searchTxt))
                            select new MenuVM
                            {
                                ID = M.ID,
                                Name=M.Name
                            }).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                menus.AddRange((from M in context.Menus
                                where M.ID == id
                                select new MenuVM
                                {
                                    ID = M.ID,
                                    Name=M.Name
                                }).ToList());
            }
            catch { }
            return menus;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Menus.Remove(context.Menus.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Menu menu)
        {
            try
            {
                Menu editedMenu = context.Menus.Find(menu.ID);

                editedMenu.ID = menu.ID;
                editedMenu.Name = menu.Name;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(Menu menu)
        {
            try
            {
                context.Menus.Add(menu);

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
