using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandlerHMS
{
    public class Exceptional : ApplicationException
    {
        public Exceptional() : base() { }
        public Exceptional(string message) : base(message) { }
        public Exceptional(string message, Exceptional innerException)
            : base(message, innerException) { }
    }
}
