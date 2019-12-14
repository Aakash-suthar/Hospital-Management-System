using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHMS
{
    [Serializable]
    public class InpatientAppointment
    {
        public string AppointmentId { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public string DateOfVisitation { get; set; }
        public string AdmissionDate { get; set; }
        public string DischargeDAte { get; set; }
        public int RoomAmount { get; set; }
        

    }
}
