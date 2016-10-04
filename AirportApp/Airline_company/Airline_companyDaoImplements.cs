using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airline_company
{
    class Airline_companyDaoImplements : Airline_companyDao
    {
        public void addAirline(Airline_company airline)
        {

            DB.DBConnection db = new DB.DBConnection();
            db.addAirline(airline);

        }

        public void editAirline(Airline_company airline)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.editAirline(airline);
        }

        public void removeAirline(int id)
        {
            DB.DBConnection db = new DB.DBConnection();
            db.removeAirline(id);
        }

        public List<string> getAllAirlines()
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirlines();
        }

        public List<Airline_company> getAllAirlinesData()
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirlinesData();
        }

        public string getAirline(int id)
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirline(id);
        }

        public int getAirlineId(string name)
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirlineId(name);
        }
        public Airline_company getAirlineDataForModification(int id)
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAirlineDataModification(id);

        }

    }

}
