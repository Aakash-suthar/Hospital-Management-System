using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSystemMVCApp.Models
{
    public class Bill
    {
        [Key]
        public int Patient_Id { get; set; }
        public string DoctorName { get; set; }
        public int RoomCharge { get; set; }
        public int LabCharge { get; set; }
        public double DaysAdmitted { get; set; }
        public string PatientName { get; set; }
        public int TotalCost { get; set; }
    }
}