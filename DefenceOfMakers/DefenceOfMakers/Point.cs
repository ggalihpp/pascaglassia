using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public int distanceTo(int x, int y)
        {
            var SelisihX = X - x;
            var SelisihY = Y - y;

            var SelisihXkuadrat = SelisihX * SelisihX;
            var SelisihYkuadrat = Math.Pow(SelisihY, 2);

            var jumlah = SelisihXkuadrat + SelisihYkuadrat;
            var akar = Math.Sqrt(jumlah);

            return (int)akar;
        }
    }
}
