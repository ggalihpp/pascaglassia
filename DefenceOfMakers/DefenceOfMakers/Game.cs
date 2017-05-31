using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class Game
    {
        static void Main(string[] args)
        {

            //Point point = new Point(4, 2);
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.distanceTo(7, 4));
            Map map = new Map(8, 5);

            try
            {

                Path path = new Path(
                   new[] 
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    });

                MapLocation location = path.getLocationAt(1);
                Console.WriteLine(location.X +","+ location.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of Range . .. ");
            }
            
        }
    }
}
