using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHMS
{
    [Serializable]
    public class Patient
    {
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Disease { get; set; }
        public string DoctorId { get; set; }
    }


    [Serializable]
    public class Lab
    {
        public string LabId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoctorId { get; set; }
        public DateTime TestDate { get; set; }
        public string TestType { get; set; }
        public string PatientType { get; set; }
        public string Remark { get; set; }
        
    }
    


    [Serializable]
    public class Bill
    {
        public string BillNo { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public string PatientType { get; set; }
        public double DoctorFees { get; set; }
        public double RoomCharge { get; set; }
        public double OperationCharge { get; set; }
        public double MedicineFee { get; set; }
        public int TotalDays { get; set; }
        public double LabFees { get; set; }
        public double Total { get; set; }
    }
}
