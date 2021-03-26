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

        static App()
        {
            GetImagesPath();
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