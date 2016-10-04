using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Fly
{
    class Fly
    {
        private int id;

        private string start_point;
        private string destination;
        private DateTime departure_time;
        private DateTime landing_time;
        private int airplane_id;
        private string airline;

        public Fly(int id, string start_point, string destination, DateTime departure_time, DateTime landing_time, string airline) {
            this.id = id;
            this.start_point = start_point;
            this.destination = destination;
            this.departure_time = departure_time;
            this.landing_time = landing_time;
            this.airline = airline;
        }
        public Fly(int id, string start_point, string destination, string departure_time, string landing_time, string airline)
        {
            this.id = id;
            this.start_point = start_point;
            this.destination = destination;
            this.departure_time = Convert.ToDateTime(departure_time);
            this.landing_time = Convert.ToDateTime(landing_time);
            this.airline = airline;
        }

        public Fly(int id, string start_point, string destination, DateTime departure_time, DateTime landing_time, int airplane_id)
        {
            this.id = id;
            this.start_point = start_point;
            this.destination = destination;
            this.departure_time = departure_time;
            this.landing_time = landing_time;
            this.airplane_id = airplane_id;
        }
        
        public Fly(string start_point, string destination, DateTime departure_time, DateTime landing_time, int airplane_id)
        {
         
            this.start_point = start_point;
            this.destination = destination;
            this.departure_time = departure_time;
            this.landing_time = landing_time;
            this.airplane_id = airplane_id;
        }

        public Fly(int id, string start_point, string destination) {
            this.destination = destination;
            this.start_point = start_point;
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public DateTime Departure_time
        {
            get { return departure_time; }
            set { departure_time = value; }
        }

        public string Start_point
        {
            get { return start_point; }
            set { start_point = value; }
        }

        public DateTime Landing_time
        {
            get { return landing_time; }
            set { landing_time = value; }
        }

        public int Airplane_id
        {
            get { return airplane_id; }
            set { airplane_id = value; }
        }

    }
}
