using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{

    /// <summary>
    /// Customer Exception 
    /// </summary>
    class CustomerException : Exception
    {

        public CustomerException(string message)
        : base(message)
        {
        }

        public CustomerException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
