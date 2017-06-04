using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class Tower
    {
        private readonly MapLocation _location;
        private static Random randomGenerator = new Random();
        const int _range = 1;
        const int _power = 3;
        private const double _accuracy = 0.75;

       

        public Tower(MapLocation Location)
        {
            _location = Location;
        }

        public void FireToInvader(Invader[] invaders)
        {
            foreach(var satuInvader in invaders)
            {
                if (satuInvader.IsActive && _location.inRangeOf(satuInvader.Location, 1))
                {
                    if (randomGenerator.NextDouble() < _accuracy)
                    {
                        satuInvader.decreaseHealth(_power);
                        Console.WriteLine("invader shooted succesfully");

                        if (satuInvader.IsNeutralized)
                            Console.WriteLine("invader neutralized");
                    }
                    else
                    {
                        Console.WriteLine("invader shooted missed");
                    }
                    break;
                }
            }

        }
    }
}
