using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class UserController : ICRUD<User, UserVM>
    {
        public static RestaurantEntities context;

        static UserController()
        {
            context = new RestaurantEntities();
        }

        public User GetUser(int id)
        {
            return context.Users.Find(id);
        }

        public List<UserVM> ViewUsersType(UserType type)
        {
            return (from u in context.Users
                    where u.UserType.ID == type.ID
                    select new UserVM
                    {
                        ID = u.ID,
                        FristName = u.FristName,
                        LastName = u.LastName,
                        Username = u.Username,
                        Email = u.Email,
                        TypeName = u.UserType.Name,
                    }).ToList();
        }

        public List<UserVM> ViewAll()
        {
            var users = (from u in context.Users
                         select new UserVM
                         {
                             ID = u.ID,
                             FristName = u.FristName,
                             LastName = u.LastName,
                             Username = u.Username,
                             Email = u.Email,
                             TypeName = u.UserType.Name,
                         }).ToList();

            return users;
        }

        public List<UserVM> Search(string searchTxt)
        {
            List<UserVM> users = new List<UserVM>();

            users.AddRange((from u in context.Users
                            where (u.FristName.Contains(searchTxt)
                            || u.LastName.Contains(searchTxt)
                            || u.Username.Contains(searchTxt)
                            || u.UserType.Name.Contains(searchTxt)
                            || u.Email.Contains(searchTxt))
                            select new UserVM
                            {
                                ID = u.ID,
                                FristName = u.FristName,
                                LastName = u.LastName,
                                Username = u.Username,
                                Email = u.Email,
                                TypeName = u.UserType.Name,
                            }).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                users.AddRange((from u in context.Users
                                where u.ID == id
                                select new UserVM
                                {
                                    ID = u.ID,
                                    FristName = u.FristName,
                                    LastName = u.LastName,
                                    Username = u.Username,
                                    Email = u.Email,
                                    TypeName = u.UserType.Name,
                                }).ToList());
            }
            catch { }
            return users;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Users.Remove(context.Users.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(User user)
        {
            try
            {
                User editedUser = context.Users.Find(user.ID);

                editedUser.FristName = user.FristName;
                editedUser.LastName = user.LastName;
                editedUser.Email = user.Email;
                editedUser.Username = user.Username;
                editedUser.UserType = user.UserType;
                editedUser.Password = user.Password;

                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(User user)
        {
            try
            {
                context.Users.Add(user);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public User Login(User user)
        {
            User user1 = (from u in context.Users
                          where (u.Email == user.Email
                          || u.Username == user.Username)
                          select u).FirstOrDefault();

            if (user1 == null)
                return null;
            else
            {
                if (user1.Password != user.Password)
                {
                    user.Password = null;
                }
                return user;
            }
        }
    }
}