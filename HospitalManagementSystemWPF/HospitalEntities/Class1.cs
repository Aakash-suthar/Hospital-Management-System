using System;
using System.Collections.Generic;
/// <summary>
/// This file contains all the entities related to the project such as Patient,Rooms,Doctors etc. 
/// </summary>
namespace HospitalEntities
{
    public class Patient
    {
        public int Patient_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    public class Doctors
    {
        public int Doctor_Id { get; set; }
        public string Doctor_Name { get; set; }
        public string Department { get; set; }
    }

    public class Bill
    {
        public int Bill_Id { get; set; }
        public int Patient_Id { get; set; }
        public string Doctor_Assigned { get; set; }
        public int RoomCharge { get; set; }
        public int LabCharge { get; set; }
        public double DaysAdmitted { get; set; }
        public int TotalCost { get; set; }
        public string PatientName { get; set; }
    }
    
    public class InPatients
    {
        public int Patient_Id { get; set; }
        public DateTime AdmitDate { get; set; }
        public int DoctorAssigned { get; set; }
        public string Disease { get; set; }
        public int RoomAssigned { get; set; }

    }
    public class Lab
    {
        public int Lab_Id { get; set; }
        public int Patient_Id { get; set; }
        public string TestName { get; set; }
        public int TestCost { get; set; }
    }
    public class PatientHistory
    {
        public int Patient_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string DoctorAssigned { get; set; }
        public string Disease { get; set; }
        public string RoomAssigned { get; set; }
    }
    public class Room
    {
        public int Room_Id { get; set; }
        public string Room_Name { get; set; }
        public int ?Patient_Id { get; set; }
        public int Room_Charge { get; set; }
    }
    public class SearchablePatients
    {
        public List<string> Name { get; set; }
    }
}
