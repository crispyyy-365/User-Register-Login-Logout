using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Login
{
    internal class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsLogin { get; set; }
        public User(string name, string surname, string password, string confirmPassword)
        {
            Name = name;
            Surname = surname;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
