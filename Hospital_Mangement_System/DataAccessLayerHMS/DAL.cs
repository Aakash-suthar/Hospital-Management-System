using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EntityHMS;

namespace DataAccessLayerHMS
{
    public class DAL
    {
        public static List<Patient> patientList = new List<Patient>();
        public static List<Lab> labList = new List<Lab>();
        public static List<Bill> billList = new List<Bill>();
        public static List<Doctor> doctorList = new List<Doctor>();
        public static List<InpatientAppointment> inpatientList = new List<InpatientAppointment>();


        public static string patientFile = "PatientData";
        public static string DoctorFile = "DoctorData";
        public static string LabData = "LabData";
        public static string BillData = "BillData";
        public static string InpatientData = "Inpatient";



        // add patient -----------------------------------------------------------------------
        public bool AddPatientDAL(Patient newpatient)
        {
            bool patientAdded = false;
            try
            {
                patientList.Add(newpatient);
                patientAdded = true;
                SetSerialization();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return patientAdded;
        }
        
        public bool AddLabDAL(Lab newReport)
        {
            bool reportAdded = false;
            try
            {
                labList.Add(newReport);
                reportAdded = true;
                LabSetSerialization();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return reportAdded;
        }
        
        
        public bool AddInpatientDAL(InpatientAppointment add)
        {
            bool Added = false;
            try
            {
                inpatientList.Add(add);
                Added = true;
                InpatientSetSerialization();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return Added;
        }
        
        public bool AddDoctorDAL(Doctor newDoctor)
        {
            bool doctorAdded = false;
            try
            {
                doctorList.Add(newDoctor);
                doctorAdded = true;
                SetDoctorSerialization();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return doctorAdded;

        }
        
        public bool AddBillDAL(Bill newbill)
        {
            bool billAdded = false;
            try
            {
                billList.Add(newbill);
                billAdded = true;
                SetBillSerialization();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return billAdded;
        }
      
        public List<Patient> GetAllPatientsDAL()
        {
            return patientList;
        }
        // Serialization---------------------------------------------------------------------------------------------------------------------
        private static void SetSerialization()
        {
            FileStream fs = new FileStream(patientFile, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, patientList);
            fs.Close();
        }
               
        private static void SetBillSerialization()
        {
            FileStream fs = new FileStream(BillData, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, billList);
            
            fs.Close();

        }
        
        private static void LabSetSerialization()
        {
            FileStream fs = new FileStream(LabData, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, labList);
            
            fs.Close();
        }
       
        private static void InpatientSetSerialization()
        {
            FileStream fs = new FileStream(InpatientData, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, inpatientList);
            
            fs.Close();
        }
        
        private static void SetDoctorSerialization()
        {
            FileStream fs = new FileStream(DoctorFile, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, doctorList);
            
            fs.Close();
        }
        //---------------------------------------------------------------------------------------------------------------------
        //Deserialization---------------------------------------------------------------------------------------------------------------------
        public static List<Patient> Deserialize()
        {
            try
            {
                FileStream fs = new FileStream(patientFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                patientList = bf.Deserialize(fs) as List<Patient>;
                fs.Close();
                return patientList;
            }
            catch (FileNotFoundException)
            {
                return null;
            }

        }
        public static List<Doctor> DeserializeDoctor()
        {
            try
            {


                FileStream fs = new FileStream(DoctorFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                doctorList = bf.Deserialize(fs) as List<Doctor>;
                fs.Close();
                return doctorList;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
        public static List<Lab> DeserializeLab()
        {
            try
            {
                FileStream fs = new FileStream(LabData, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                labList = bf.Deserialize(fs) as List<Lab>;
                fs.Close();
                return labList;
            }
            catch (FileNotFoundException)
            { return null; }
        }
        public static List<Bill> DeserializeBill()
        {
            try
            {
                FileStream fs = new FileStream(BillData, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                billList = bf.Deserialize(fs) as List<Bill>;
                fs.Close();
                return billList;
            }
            catch(FileNotFoundException)
            {
                return null;
            } 
        }
        public static List<InpatientAppointment> DeserializeInpatient()
        {
            try
            {
                FileStream fs = new FileStream(InpatientData, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                inpatientList = bf.Deserialize(fs) as List<InpatientAppointment>;
                fs.Close();

                return inpatientList;
            }
            catch (FileNotFoundException)
            { return null; }

        }
       
        //---------------------------------------------------------------------------------------------------------------------
        public bool UpdatePatientDAL(Patient updatePatient)
        {
            bool patientUpdated = false;
            try
            {
                for (int i = 0; i < patientList.Count; i++)
                {
                    if (patientList[i].PatientName == updatePatient.PatientName)
                    {
                        updatePatient.PatientId = patientList[i].PatientId;
                        updatePatient.Age = patientList[i].Age;
                        updatePatient.Weight = patientList[i].Weight;
                        updatePatient.Gender = patientList[i].Gender;
                        updatePatient.Address = patientList[i].Address;
                        updatePatient.PhoneNo = patientList[i].PhoneNo;
                        updatePatient.Disease = patientList[i].Disease;
                        updatePatient.DoctorId = patientList[i].DoctorId;

                        patientUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return patientUpdated;

        }
        //---------------------------------------------------------------------------------------------------------------------
       
        //SEarch---------------------------------------------------------------------------------------------------------------------
        public static Bill SearchBill(string searchPatientId)
        {
            Bill searchPatient = null;
            try
            {
                searchPatient = (billList.Find(p => p.PatientId == searchPatientId));
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }
        public static Lab SearchLabDAL(string searchPatientId)
        {
            Lab searchPatient = null;
            try
            {
                searchPatient = (labList.Find(p => p.PatientId == searchPatientId));
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientDALlistreturnage(int age)
        {
            List<Patient> searchPatient = null;
            try
            {
                searchPatient = patientList.FindAll(p => p.Age == age).ToList();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientDALlistreturnname(string name)
        {
            List<Patient> searchPatient = null;
            try
            {
                searchPatient = patientList.FindAll(p => p.PatientName == name ).ToList();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientDALlistreturnweight(int w)
        {
            List<Patient> searchPatient = null;
            try
            {
                searchPatient = patientList.FindAll(p => p.Weight == w).ToList();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }

        public static InpatientAppointment SearchInPatientDAL(string searchPatientId)
        {
            InpatientAppointment searchPatient = null;
            try
            {
                searchPatient = new InpatientAppointment();
                searchPatient = (inpatientList.Find(p => p.PatientId == searchPatientId));
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }
        public static List<Doctor> SearchDoctorDAL()
        {
            List<Doctor> searchDoctor = null;
            try
            {
                searchDoctor = doctorList;
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchDoctor;
        }

        public static Patient SearchPatientDAL(string searchPatientId)
        {
            Patient searchPatient = null;
            try
            {
                searchPatient = patientList.Find(p => p.PatientId == searchPatientId);
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }

        public static List<Patient> SearchPatientDALlistreturn(string searchPatientId)
        {
            List<Patient> searchPatient = null;
            try
            {
                searchPatient = patientList.FindAll(p => p.PatientId == searchPatientId).ToList();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }
        public static List<Patient> SearchPatientDALName(string searchPatientId)
        {
            List<Patient> searchPatient = null;
            try
            {
                searchPatient = patientList.FindAll(p => p.PatientId == searchPatientId).ToList();
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchPatient;
        }
    }
}
