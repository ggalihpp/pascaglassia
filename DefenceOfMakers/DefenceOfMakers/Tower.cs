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
        const int _range = 1;
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
                    satuInvader.decreaseHealth(1);
                    break;
                }
            }

        }
    }
}
