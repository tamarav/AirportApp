using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airplane
{
    class AirplaneDaoImplements : AirplaneDao
    {
        public void addAirplane(Airplane airplane)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.addAirplane(airplane);
        }

        public void removeAirplane(int id)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.removeAirplane(id);
        }

        public List<Airplane> getAllAirplanes()
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAllAirplanes();
        }

        public void editAirplane(Airplane airplane)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.editAirplane(airplane);
        }

        public Airplane getAirplane(int id)
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirplane(id);
        }
        public Airplane getAirplaneName(string name)
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirplaneName(name);
        }
    }
}
