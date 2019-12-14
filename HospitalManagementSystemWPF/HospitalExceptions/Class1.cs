using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExceptions
{
    public class HospitalExceptions : ApplicationException
    {
        public HospitalExceptions()
        {
        }

        public HospitalExceptions(string message) : base(message)
        {
        }

        public HospitalExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
