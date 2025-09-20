using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm_App
{
    public class LoginDetails
    {
        private string _username;
        private string _password;
        public LoginDetails(string user,string pwd)
        {
            Username = user;
            Password = pwd;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

    }
}
