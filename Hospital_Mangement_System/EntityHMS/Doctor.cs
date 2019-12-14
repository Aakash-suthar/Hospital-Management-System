using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHMS
{
    [Serializable]
    public class Doctor
    {
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Dept { get; set; }
    }
}
