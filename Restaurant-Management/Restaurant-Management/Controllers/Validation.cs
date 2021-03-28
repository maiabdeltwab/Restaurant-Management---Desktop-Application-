using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal static class Validation
    {
        #region regex validation

        private static readonly Regex usernameReg = new Regex("^([a-z0-9]|[-._](?![-._])){3,}$");
        private static readonly Regex nameReg = new Regex("^[A-Za-z -]{3,}$");
        private static readonly Regex emailReg = new Regex("^[\\w\\-\\.\\+]+\\@[a-zA-Z0-9\\.\\-]+\\.[a-zA-z0-9]{2,4}$");
        private static readonly Regex PhoneReg = new Regex("^(012||011||015||010)\\d{8}$");
        private static readonly Regex countRegex = new Regex("^[0-9]*$");

        #endregion regex validation

        #region validation methods

        public static bool IsName(string name)
        {
            if (nameReg.IsMatch(name))
                return true;

            return false;
        }

        public static bool IsEmail(string email)
        {
            if (emailReg.IsMatch(email))
                return true;

            return false;
        }

        public static bool IsUsername(string username)
        {
            if (usernameReg.IsMatch(username))
                return true;

            return false;
        }

        public static bool IsPhone(string phone)
        {
            if (PhoneReg.IsMatch(phone))
                return true;

            return false;
        }

        public static bool isInteger(string count)
        {
            if (countRegex.IsMatch(count))
                return true;

            return false;
        }

        public static bool IsDecimal(string price)
        {
            try
            {
                decimal.Parse(price);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion validation methods
    }
}