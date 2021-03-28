using Restaurant_Management.Controllers;
using Restaurant_Management.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    internal static class App
    {
        public static User UserLogin { get; set; }

        public static string ImagePath { get; set; }

        private static RestaurantEntities context = SupplierController.context;

        static App()
        {
            GetImagesPath();

            var login = context.SaveLogins.FirstOrDefault();
            if (login != null)
                UserLogin = context.Users.Find(login.userId);
            else
                UserLogin = null;
        }

        private static void GetImagesPath()
        {
            ImagePath = Directory.GetCurrentDirectory();
            string[] sl = ImagePath.Split('\\');

            ImagePath = "";

            foreach (string s in sl)
            {
                if (s == "bin")
                    break;
                else
                    if (ImagePath == "")
                    ImagePath = s;
                else
                    ImagePath += "\\" + s;
            }

            ImagePath += "\\View\\images";
        }
    }
}