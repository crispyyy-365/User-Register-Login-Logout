using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Login
{
    internal interface IAccountService
    {
        void Register(User user);
        void Login(string userName, string password);
        void Logout();
    }
}