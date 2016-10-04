using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Airplane
{
    interface AirplaneDao
    {
        void addAirplane(Airplane airplane);
        void removeAirplane(int id);
        List<Airplane> getAllAirplanes();
        void editAirplane(Airplane airplane);
        Airplane getAirplane(int id);
        Airplane getAirplaneName(string name);
    }
}
