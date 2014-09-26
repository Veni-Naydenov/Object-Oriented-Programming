using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGps
{
    class TestGps
    {
        static void Main()
        {

            Location location = new Location(13.123456, 15.333666, Planet.Jupiter);

            Console.WriteLine(location.ToString());
            Console.WriteLine("\t{0} has order {1} in the Sun system\n", location.Planet, (int)location.Planet);

            Location location2 = new Location(333.123456, 150.3336, Planet.Venus);

            Console.WriteLine(location2.ToString());
            Console.WriteLine("\t{0} has order {1} in the Sun system", location2.Planet, (int)location2.Planet);

        }
    }
}
