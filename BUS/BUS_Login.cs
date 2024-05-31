using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Login
    {
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "admin";

        public bool ValidLogin(string username, string password)
        {
            return (username == DefaultUsername && password == DefaultPassword);
        }
    }
}
