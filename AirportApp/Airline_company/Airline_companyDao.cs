using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airline_company
{
    interface Airline_companyDao
    {
        void addAirline(Airline_company airline);
        void editAirline(Airline_company airline);
        void removeAirline(int id);
        List<string> getAllAirlines();
        List<Airline_company> getAllAirlinesData();
        string getAirline(int id);
        int getAirlineId(string name);
        Airline_company getAirlineDataForModification(int id);
    }
}
