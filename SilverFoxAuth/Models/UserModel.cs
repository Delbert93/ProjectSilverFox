using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverFoxAuth.Models
{
    public class UserModel
    {

        //strings are automatically immutable, but c#, under the hood, makes it seem like you can change it, when it's really just creating a new string
        private string username;
        private string password;

        public bool ValidatePassword(string password)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
            return isValidated;
        }

        public bool ValidateUsername(string username)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasMaximum16Chars = new Regex(@".{,16}");

            var isValidated = hasNumber.IsMatch(username) && hasUpperChar.IsMatch(username) && hasMinimum8Chars.IsMatch(username);
            return isValidated;
        }
    }
}
