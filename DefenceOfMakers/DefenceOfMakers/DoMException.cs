using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class DoMException : Exception
    {
        public DoMException()
        {

        }

        public DoMException(string message) : base(message)
        {

        }

    }

    class OutOfBondException : DoMException
    {
        public OutOfBondException()
        {

        }

        public OutOfBondException(string message) : base(message)
        {

        }
    }
}
