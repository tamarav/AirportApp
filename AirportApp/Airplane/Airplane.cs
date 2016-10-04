using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airplane
{
    class Airplane
    {
        private int id;
        private string name;
        private int number_of_seats;
        private int airline_company_id;
        private string mod;

        public Airplane(int id, string name, int number_of_seats, int airline_company_id)
        {
            this.id = id;
            this.name = name;
            this.number_of_seats = number_of_seats;
            this.airline_company_id = airline_company_id;
        }

        public Airplane(string name, int number_of_seats, int airline_company_id)
        {
            this.name = name;
            this.number_of_seats = number_of_seats;
            this.airline_company_id = airline_company_id;
        }
        public Airplane(string name, string number_of_seats, int airline_company_id)
        {
            this.name = name;
            this.number_of_seats = Convert.ToInt32(number_of_seats);
            this.airline_company_id = airline_company_id;
        }

        public Airplane(string name, int number_of_seats)
        {
            this.name = name;
            this.number_of_seats = number_of_seats;
        }

        public Airplane(string mod)
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


        public int Airline_company_id
        {
            get { return airline_company_id; }
            set { airline_company_id = value; }
        }


        public int Number_of_seats
        {
            get { return number_of_seats; }
            set { number_of_seats = value; }
        }
    }
}
