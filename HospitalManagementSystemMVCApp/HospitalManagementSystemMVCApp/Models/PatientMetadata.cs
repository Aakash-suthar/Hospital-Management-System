using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSystemMVCApp.Models
{
    public class PatientMetadata
    {
        [Key]
        public string PatientId;
        [Required]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage = "Name shoud contain alphabet only.")]
        public string Name;
        [Required]
        [Range(0, 100)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        public Nullable<int> Age;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0, 200)]
        public Nullable<int> Weight;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name shoud contain alphabet only.")]
        public string Gender;
        [Required]
        [StringLength(100)]
        public string Address;
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = " Phone number is not proper.")]
        public Nullable<long> PhoneNo;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Disease shoud contain alphabet only.")]
        public string Disease;
        [Required]
        public string DoctorId;
    }

    public class OutpatientMetadata
    {
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> TreatementDate;
        [Required]
        public string DoctorId;
        [Required]
        public string LabNo;
    }

    public class InpatientMetadata
    {
        [Required]
        public string RoomNo;
        [Required]
        public string DoctorId;
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> AdmissionDate;
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DischargeDate;
        [Required]
        public string LabNo;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public Nullable<double> AmountPerDay;
  }

    public class LabMetadat
    {
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> TestDate;
        [Required]
        public string TestType;
        [Required]
        public string PatientType;
    }

    public class BillDaaMetadata {
        [Required]
        public string BillNo;
        [Required]
        public string PatientId;
        [Required]
        public string PatientType;
        [Required]
        public string DoctorId;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0,99999999)]
        public Nullable<double> DoctorFees;
        [Required]
        [Range(0, 99999999)]
        public Nullable<double> RoomCharge;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0, 99999999)]
        public Nullable<double> OperationCharges;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0, 99999999)]
        public Nullable<double> MedicineFees;
        [Required]
        public Nullable<int> TotalDays;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0, 99999999)]
        public Nullable<double> LabFees;
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number only")]
        [Range(0, 99999999)]
        public Nullable<double> TotalAmount;
    }

    public class LogintableMetadata {
        [Required]
        public string username;
        [Required]
        public string pass;
    }

    public class RoomDataMetadata {
        [Required]
        public string RoomNo;
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> TreatementDate;
    }

    public class DoctorMetadata {
        [Required]
        public string DoctorId;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name shoud contain alphabet only.")]
        public string DoctorName;
        [Required]
        public string Dept;
    }
}