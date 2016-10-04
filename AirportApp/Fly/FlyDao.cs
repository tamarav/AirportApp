using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Fly
{
    interface FlyDao
    {
        void addFlight(Fly flight);
        List<Fly> getAllFlights();
        void editFlight(Fly flight);
        void removeFlight(int id);
        Fly getFlight(int id);
    }
}
