namespace CSharpCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Storing data in array
            //BusRoutes route40 = new BusRoutes(40, "Morecambe", "Preston");
            //BusRoutes route42 = new BusRoutes(42, "Lancaster", "Balckpool");

            ////Declaring array with values
            //BusRoutes[] routes =
            //{
            //    route40,
            //    route42,
            //    new BusRoutes(50, "La pema", "casabito"),
            //    new BusRoutes(75, "la vega", "santiago")
            //};

            ////Declaring array without specifying the data up front. you need to specify the length of the array inside th brackets
            //BusRoutes[] busRoutes = new BusRoutes[4];

            //busRoutes[0] = route40;
            //busRoutes[1] = route42;
            //busRoutes[2] = new BusRoutes(45, "la canita", "snato domingo");
            //busRoutes[3] = new BusRoutes(85, "la zurza", "simon bolivar");



            ////Look up an elemnt in the array using the index(indicates the position in the array). In C# the index starts in 0
            //BusRoutes firstElement = routes[0];

            ////The Length property tells how many items are int the array
            //int arrayLength = routes.Length;
            //Console.WriteLine(firstElement);


            ////If you dont know the length of the array you can use the length property to calculate the last index
            //BusRoutes lastRoute = routes[routes.Length - 1];
            //Console.WriteLine(lastRoute);

            ////In c# 8 or later you can use a better syntax
            //BusRoutes lastRouteNewSyntax = routes[^1];
            //Console.WriteLine(lastRouteNewSyntax);


            ////If only one statement can omit the braces
            //foreach (BusRoutes route in routes)
            //    Console.WriteLine(route);

            ////wiht the for loop you can access the index, and also have more control of wich items you wnat to enumerate.
            //for (int i = 0; i < routes.Length; i++)
            //{
            //    Console.WriteLine($"{i}: {routes[i]}");
            //}

            //Console.ReadLine();
            #endregion

            #region Finding data in array
            BusRoutes[] allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine("Where do you want to go");
            string location = Console.ReadLine();

            BusRoutes[] routes = FindBusesTo(allRoutes, location);

            if(routes.Length > 0)
                foreach (BusRoutes route in routes)
                    Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go to {location}");
            #endregion
        }

        public static BusRoutes[] FindBusesTo(BusRoutes[] routes, string location)
        {
            return Array.FindAll(routes, route => route.Serves(location));
            //foreach (BusRoutes route in routes)
            //{
            //    if(route.Origin == location || route.Destination == location)   
            //            return route;
            //}
            //return null;
        }
    }
}