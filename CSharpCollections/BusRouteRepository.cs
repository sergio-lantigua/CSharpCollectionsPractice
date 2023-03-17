using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public  class BusRouteRepository
    {
        public static BusRoutes[] InitializeRoutes()
        {

            return new BusRoutes[] 
            { new BusRoutes(45, new string[] {"La vega", "Santiago", "Puerto Plata"}),
            new BusRoutes(45, new string[] {"La vega", "Santiago", "Samana"}),
            new BusRoutes(45, new string[] {"La vega", "Monte Cristi"}),
            new BusRoutes(45, new string[] {"La vega", "Santiago", "Nagua" })
            };
        }

        public static List<BusRoutes> InitializeRoutesList()
        {

            return new List<BusRoutes>()
            { new BusRoutes(45, new string[] {"La vega", "Santiago", "Puerto Plata"}),
            new BusRoutes(45, new string[] {"La vega", "Santiago", "Samana"}),
            new BusRoutes(45, new string[] {"La vega", "Monte Cristi"}),
            new BusRoutes(45, new string[] {"La vega", "Santiago", "Nagua" }),
            new BusRoutes(45, new string[] {"Test route", "Santiago", "Test Route" })
            };
        }

    }
}
