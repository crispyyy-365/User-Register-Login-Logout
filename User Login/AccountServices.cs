using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Login
{
    internal class AccountService : IAccountService
    {
        List<User> users = new List<User>();

        public void Register(User user)
        {
            foreach (var item in users)
            {
                if (user.UserName == item.UserName)
                    Console.WriteLine("User name is taken, try something else.");
            }
            if (user.Password == user.ConfirmPassword && user.Password.Length >= 8)
                users.Add(user);
            else
                Console.WriteLine("Password is invalid, should be the same as confirm password and at least 8 symbols.");
        }
        public void Login(string userName, string password)
        {
            foreach (var user in users)
            {
                if (userName == user.Name && password == user.Password)
                    user.IsLogin = true;
                else
                    Console.WriteLine("There is no such user.");
            }
        }
        public void Logout()
        {
            foreach (var user in users)
                user.IsLogin = false;
        }
    }
}
