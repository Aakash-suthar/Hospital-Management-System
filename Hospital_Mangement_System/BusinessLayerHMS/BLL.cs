using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityHMS;
using DataAccessLayerHMS;
using System.Text.RegularExpressions;

namespace BusinessLayerHMS
{
    public class BLL
    {

        private static bool ValidatePatient(Patient patient)
        {
            StringBuilder sb = new StringBuilder();
            bool validPatient = true;
            if (patient.PatientId == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Patient Id is Required!");

            }
            if (patient.PatientName == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Patient Name is Required");

            }
            if (!Regex.IsMatch(patient.PatientName, (@"^[a-zA-Z]+$")))
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Patient Name is invalid");
            }
            if (patient.Age <= 0|| patient.Age>=100)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Invalid Age");
            }
            if (patient.Weight <= 0)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Invalid Weight");
            }
            if (patient.Gender == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Gender is Required");

            }
            if (!(patient.Gender == "female" || patient.Gender == "male"))
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Gender should be either male or female");

               
            }
            if (patient.Address == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Address is Required");

            }
            if (patient.PhoneNo == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Phone Number is Required");
            }
             if (!Regex.IsMatch(patient.PhoneNo, (@"^[789]\d{9}$")))
                {
                validPatient = false;
                sb.Append(Environment.NewLine + "Phone Number should start with 7,8 or 9");
                }
            if (patient.Disease == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Disease is Required");

            }
            if (patient.DoctorId == string.Empty)
            {
                validPatient = false;
                sb.Append(Environment.NewLine + "Doctor is Required");

            }
            if (validPatient == false)
                throw new Exception(sb.ToString());
            return validPatient;
        }

  // Addd---------------------------------------------------------------------------------------------------------------------

        public static bool AddPatientBLL(Patient newPatient)
        {
            bool patientAdded = false;
            try
            {
                if (ValidatePatient(newPatient))
                {
                   DAL  patientDAL = new DAL();
                    patientAdded = patientDAL.AddPatientDAL(newPatient);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return patientAdded;
        }
        public static bool AddLabBLL(Lab newReport)
        {
            bool reportAdded = false;
            try
            {
           
                    DAL patientDAL = new DAL();
                    reportAdded = patientDAL.AddLabDAL(newReport);
               
            }
            catch (Exception)
            {
                throw;
            }

            return reportAdded;

        }
        public static bool AddBillBLL(Bill newBill)
        {
            bool billAdded = false;
            try
            {

                DAL billDAL = new DAL();
                billAdded = billDAL.AddBillDAL(newBill);

            }
            catch (Exception)
            {
                throw;
            }

            return billAdded;

        }
        public static bool AddInpatient(InpatientAppointment appointmentadd)
        {

            bool added = false;
            try
            {
               
                
                  DAL inpatientDAL = new DAL();
                   added = inpatientDAL.AddInpatientDAL(appointmentadd);
                
            }
            catch (Exception)
            {
                throw;
            }

            return added;
        }
        public static bool AddDOctorBLL(Doctor newDoctor)
        {
            bool doctorAdded = false;
            try
            {
                    DAL doctorDAL = new DAL();
                    doctorAdded = doctorDAL.AddDoctorDAL(newDoctor);
              
            }
            catch (Exception)
            {
                throw;
            }

            return doctorAdded;
        }

        public static Patient SearchPatientBL(string searchPatientId)
        {
            Patient searchPatient = null;
            try
            {

                searchPatient = DAL.SearchPatientDAL(searchPatientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }

//_---------------------------------------------------------------------------------------
 //  Searching---------------------------------------------------------------------------------------------------------------------
        public static List<Patient> SearchPatientBLListreturn(string searchPatientId)
        {
            List<Patient> searchPatient = null;
            try
            {
              
                searchPatient = DAL.SearchPatientDALlistreturn(searchPatientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }

        public static List<Doctor> SearchDoctorBL()
        {
            List<Doctor> search = null;
            try
            {
                search = DAL.SearchDoctorDAL();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return search;

        }
        public static InpatientAppointment SearchInPatientBL(string searchPatientId)
        {
            InpatientAppointment searchPatient = null;
            try
            {
            
                searchPatient = DAL.SearchInPatientDAL(searchPatientId);
            }
          
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }
        public static Lab SearchLabBL(string searchPatientId)
        {
            Lab searchPatient = null;
            try
            {
               
                searchPatient = DAL.SearchLabDAL(searchPatientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }
        public static Bill SearchbillBL(string searchPatientId)
        {
            Bill searchPatient = null;
            try
            {
                
                searchPatient =DAL.SearchBill(searchPatientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }

        //---------------------------------------------------------------------------------------------------------------------

        public static bool UpdatePatientBL(Patient updatePatient)
        {
            bool patientUpdated = false;
            try
            {
                if (ValidatePatient(updatePatient))
                {
                    DAL update = new DAL();
                    patientUpdated = update.UpdatePatientDAL(updatePatient);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return patientUpdated;
        }

//Deserilize------------------------------------------------------------------------------
        public static List<Patient> bllD()
        {
            List<Patient> p = DAL.Deserialize();
            return p;
        }
        public static List<Lab> labbll()
        {
            List<Lab> p = DAL.DeserializeLab();
            return p;
        }
        public static List<Bill> billbll()
        {
            List<Bill> p = DAL.DeserializeBill();
            return p;
        }
        public static List<InpatientAppointment> inpatientbll()
        {
            List<InpatientAppointment> p = DAL.DeserializeInpatient();
            return p;
        }
        public static List<Doctor> doctord()
        {
            List<Doctor> p = DAL.DeserializeDoctor();
            return p;
        }

        public static List<Patient> SearchPatientBLListreturnage(int age)
        {
            List<Patient> searchPatient = null;
            try
            {

                searchPatient = DAL.SearchPatientDALlistreturnage(age);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientBLListreturnname(string name)
        {

            List<Patient> searchPatient = null;
            try
            {

                searchPatient = DAL.SearchPatientDALlistreturnname(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientBLListreturnweight(int w)
        {
            List<Patient> searchPatient = null;
            try
            {

                searchPatient = DAL.SearchPatientDALlistreturnweight(w);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchPatient;
        }
    }//-------------------------------------------------------------------------------------------
}
