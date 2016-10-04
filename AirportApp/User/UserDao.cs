using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.User
{
    interface UserDao
    {
        Boolean isExisting(string username);
        void addUser(User user);
        User getUser(string username, string password);
    }
}
