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

            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9]*$");
            var hasMinimum12Chars = new Regex(@".{12,}");

            var isValidated = objAlphaPattern.IsMatch(password) && hasMinimum12Chars.IsMatch(password);
            return isValidated;
        }

        public bool ValidateUsername(string username)
        {

            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9]*$");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = objAlphaPattern.IsMatch(username) && hasMinimum8Chars.IsMatch(username);
            return isValidated;
        }
    }
}
