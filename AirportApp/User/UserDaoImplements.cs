
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.User
{
    class UserDaoImplements : UserDao
    {
        public Boolean isExisting(string username)
        {
            DB.DBConnection db = new DB.DBConnection();
            User user = db.getUser(username);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public void addUser(User user)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.addUser(user);
        }

        public User getUser(string username, string password)
        {
            DB.DBConnection db = new DB.DBConnection();
            User user = db.getUser(username);

            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }
    }
}
