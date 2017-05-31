using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public bool OnMap(Point point)
        {
            var panjang = point.X < Width && point.X >= 0;
            var lebar = point.Y < Height && point.Y >= 0;

            return panjang && lebar;
        }

    }
}
