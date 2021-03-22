using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    internal static class Basic
    {
        private static string imagePath;

        static Basic()
        {
            GetImagesPath();
        }

        public static string ImagePath { get => imagePath; set => imagePath = value; }

        private static void GetImagesPath()
        {
            imagePath = Directory.GetCurrentDirectory();
            string[] sl = imagePath.Split('\\');

            imagePath = "";

            foreach (string s in sl)
            {
                if (s == "bin")
                    break;
                else
                    if (imagePath == "")
                    imagePath = s;
                else
                    imagePath += "\\" + s;
            }

            imagePath += "\\View\\images";
        }
    }
}