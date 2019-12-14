using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HospitalEntities;

/// <summary>
/// This is the business layer for the project, 
/// and it contains the validations for inputs which the user might enter
/// </summary>
namespace HospitalBusinessLayer
{
    public class HospitalBAL
    {
        //Method for adding new patient
        public static bool AddPatient(Patient patient)
        {
            return (HospitalDataAccessLayer.HospitalDAL.AddPatient(patient));
        }
        //Method for searching
        public static Patient SearchPatient(int patient_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.SearchPatient(patient_id);
        }
        //Method to update an existing patient
        public static bool UpdatePatient(Patient patient)
        {
            return HospitalDataAccessLayer.HospitalDAL.UpdatePatient(patient);
        }
        //Method for getting the patients details.This is used for fetching and populating the dropdown
        public static List<Patient> GetPatients()
        {
            return HospitalDataAccessLayer.HospitalDAL.GetPatients();
        }
        //For searching the inpatients in the hospital
        public static InPatients SearchInPatient(int patient_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.SearchInPatient(patient_id);
        }
        //Find the patient by their ID
        public static string GetPatientNameById(int patient_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.GetPatientNameById(patient_id);
        }
        //Get the doctor's list to populate the dropdown
        public static List<Doctors> GetDoctors()
        {
            return HospitalDataAccessLayer.HospitalDAL.GetDoctors();
        }
        //This method is for validating the newly addedpatients into the hospital
        public static bool ValidateNewPatient(Patient patient)
        {

            bool isValid = true;
            if (patient.Age<1||patient.Age>150)
            {
                isValid = false;
                throw new Exception("Patient Age Is Invalid");
            }

            if (patient.Phone.ToString().Length != 10)
            {
                isValid = false;
                throw new Exception("Mobile Number should be of 10 digit");
            }
            if (!Regex.IsMatch(patient.Phone, (@"^[789]\d{9}$")))
            {
                isValid = false;
                throw new Exception("Mobile no should start with 7, 8 or 9");
            }
            return isValid;

        }

        public static string GetRoomNameById(int room_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.GetRoomNameById(room_id);
        }

        public static string GetDoctorNameById(int doc_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.GetDoctortNameById(doc_id);
        }

        //get the list of rooms to fill the dropdown
        public static List<Room> GetRooms()
        {
            return HospitalDataAccessLayer.HospitalDAL.GetRooms();
        }
        //Add a new INPATIENT
        public static bool AddInPatient(InPatients inpatient)
        {
            return HospitalDataAccessLayer.HospitalDAL.AddInPatients(inpatient);
        }
        //Generate the bill while the patient is being discharged
        public static Bill GenerateBill(int patient_id)
        {
            return HospitalDataAccessLayer.HospitalDAL.GenerateBill(patient_id);
        }
        //Method to feed the lab report data into the system
        public static bool InsertLabReportData(Lab labData)
        {
            return HospitalDataAccessLayer.HospitalDAL.InsertLabReportData(labData);
        }
    }
}
