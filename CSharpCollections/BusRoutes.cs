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
        public string Origin { get; }
        public string Destination { get; }
        public BusRoutes(int number, string origin, string destination)
        {
            Number = number;
            Origin = origin;
            Destination = destination;
        }

        public override string ToString() => $"{Number}: {Origin} -> {Destination}";
    }
}
