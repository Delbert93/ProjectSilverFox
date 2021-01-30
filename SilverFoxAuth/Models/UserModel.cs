using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public bool readFlag = false;
        public bool isValidPassword;
        public bool isValidUsername;


        public void ValidatePassword(string _password)
        {
            
            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9]*$");
            var hasMinimum12Chars = new Regex(@".{12,}");

            var isValidated = objAlphaPattern.IsMatch(_password) && hasMinimum12Chars.IsMatch(_password);
            if (isValidated)
            {
                isValidPassword = true;
                this.password = _password;
            }
            else
            {
                isValidPassword = false;
            }
        }

        public void ValidateUsername(string _username)
        {

            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9]*$");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = objAlphaPattern.IsMatch(_username) && hasMinimum8Chars.IsMatch(_username);

            if (isValidated)
            {
                isValidUsername = true;
                this.username = _username;
            }
            else
            {
                isValidUsername = false;
            }
        }

        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            if(readFlag == false)
            {
                readFlag = true;
                return this.password;
            }
            else
            {
                Trace.WriteLine("Cannot read this object more than once");
                return null;
            }
        }
    }
}
