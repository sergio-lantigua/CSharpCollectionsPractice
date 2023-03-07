using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class BusRoutes
    {
        public int Number { get; set; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];

        public string[] PlacesServed { get; }
        public BusRoutes(int number, string[] placesServed)
        {
            Number = number;
            PlacesServed = placesServed;
        }

        public override string ToString() => $"{Number}: {Origin} -> {Destination}";

        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, placeServed => placeServed == destination);
        }
    }
}
