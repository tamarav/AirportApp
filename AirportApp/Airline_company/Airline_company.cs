using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airline_company
{
    class Airline_company
    {
        private int id;
        private string name;
        private string country;
        private string address;
        private string telephone;

        private string email;
        private string mod;

        public Airline_company(string name, string country, string address, string telephone, string email)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.telephone = telephone;
            this.email = email;
        }

        public Airline_company(string name, string country, string address, string telephone, string email, int id)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.telephone = telephone;
            this.email = email;
            this.id = id;
        }
        public Airline_company(string mod)
        {
            this.mod = mod;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
