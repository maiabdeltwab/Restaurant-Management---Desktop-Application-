using Restaurant_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Screen = Restaurant_Management.Model.Screen;

namespace Restaurant_Management.Controllers
{
    internal class UserTypeController
    {
        public static RestaurantEntities context;

        static UserTypeController()
        {
            context = new RestaurantEntities();
        }

        public List<UserType> ViewAll()
        {
            var userTypes = (from ut in context.UserTypes
                             select ut).ToList();

            return userTypes;
        }

        public UserType GetUserType(int id)
        {
            return context.UserTypes.Find(id);
        }

        public List<UserType> Search(string searchTxt)
        {
            List<UserType> userTypes = new List<UserType>();

            userTypes.AddRange((from ut in context.UserTypes
                                where (ut.Name.Contains(searchTxt)
                                || ut.Description.Contains(searchTxt))
                                select ut).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                userTypes.AddRange((from ut in context.UserTypes
                                    where ut.ID == id
                                    select ut).ToList());
            }
            catch { }
            return userTypes;
        }

        public int Delete(int id)
        {
            try
            {
                if (context.Users.Where(e => e.UserType.ID == id).Count() != 0)
                    return 0;
                context.UserTypes.Remove(context.UserTypes.Find(id));
                context.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public bool DeleteUsers(int id)
        {
            try
            {
                context.Users.RemoveRange(context.Users.Where(u => u.UserType_id == id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(UserType userType)
        {
            try
            {
                UserType editedUser = context.UserTypes.Find(userType.ID);

                editedUser.Name = userType.Name;
                editedUser.Description = userType.Description;

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool Insert(UserType userType)
        {
            try
            {
                context.UserTypes.Add(userType);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Screen> GetRoleScreens(UserType role)
        {
            List<Screen> screens = new List<Screen>();
            foreach (var prv in role.UserPrivileges)
            {
                screens.Add(prv.Screen);
            }
            return screens;
        }

        public bool AssignScreens(List<Screen> screens, UserType role)
        {
            try
            {
                foreach (var screen in screens)
                {
                    context.UserPrivileges.Add(new UserPrivilege
                    {
                        UserType_id = role.ID,
                        Screen_id = screen.ID
                    });
                }

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