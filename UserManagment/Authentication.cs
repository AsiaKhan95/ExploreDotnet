using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment
{
    public class Authentication
    {
        public string UserHome(string name)
        {
            return "Hello, " + name;
        }
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                return true;
            }
            return false;
        }
    }
}
