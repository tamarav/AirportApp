using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.User
{
    class User
    {
        private int id;
        private string username, password;

        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
