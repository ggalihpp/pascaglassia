﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base (x,y)
        {
            if (!map.OnMap(this))
                throw new OutOfBondException();
        }

        public bool inRangeOf(MapLocation mapLocation, int range)
        {
            return distanceTo(mapLocation) <= range;
        }
    }
}
