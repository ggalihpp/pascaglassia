using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class FastInvader : Invader
    {

        protected override int stepSize { get; } = 3;
        public FastInvader(Path path) : base(path)
        {
                    
        } 
    }
}
