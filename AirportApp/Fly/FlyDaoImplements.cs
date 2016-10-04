using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Fly
{
    class FlyDaoImplements : FlyDao
    {
        public void addFlight(Fly flight) {
            DB.DBConnection db = new DB.DBConnection();
            db.addFlight(flight);
            Console.WriteLine("FDI ADD FLIGHT");
        }

        public List<Fly> getAllFlights() {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAllFlights();
        }

        public void editFlight(Fly flight) {
            DB.DBConnection db = new DB.DBConnection();
            db.editFlight(flight);
        }

        public void removeFlight(int id) {
            DB.DBConnection db = new DB.DBConnection();
            db.removeFlight(id);
        }

        public Fly getFlight(int id) {
            DB.DBConnection db = new DB.DBConnection();
            return db.getFlight(id);
        }
    }
}
