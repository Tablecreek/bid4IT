using BusinessLayer.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginDataService : Rest.DataClient
    {
        public static bool Login(string username, string password)
        {
            var loggedIn = username == "test" && password == "1234";

            return loggedIn;
        }
    }
}
