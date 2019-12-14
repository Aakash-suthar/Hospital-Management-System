using HospitalEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
/// <summary>
/// This is the Data access layer that will eventually interact with the database
/// and aids in performing the CRUD operations.
/// </summary>
namespace HospitalDataAccessLayer
{
    public class HospitalDAL
    {
        public static int id = 0;

        //Method to add patient into the database
        public static bool AddPatient(Patient newPatient)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            bool isAdded = false;
            SqlCommand command2 = DatabaseHelper.GetCommandObject();
            command2.Connection = conn;
            command2.CommandText = "SELECT MAX(patient_id) FROM [187057_Akash].patients";
            conn.Open();

            int newPatientId = Convert.ToInt32(command2.ExecuteScalar());
            conn.Close();
            newPatientId++;
            newPatient.Patient_Id = newPatientId;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@patient_id", newPatientId);
            command.CommandText = "SELECT COUNT(*) FROM [187057_Akash].patients WHERE patient_id = @patient_id";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            if (recordsCount != 0)
                isAdded = false;
            else
            {
                command.CommandText = "INSERT INTO [187057_Akash].patients VALUES ('" + newPatient.Patient_Id + "', '" + newPatient.Name + "', '" + newPatient.Age + "', '" + newPatient.Gender + "', '" + newPatient.Address + "', '" + newPatient.Phone + "');";
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isAdded = true;
                }
                conn.Close();
                command.Dispose();
            }
            return isAdded;
        }
        //Method for bill generation
        public static Bill GenerateBill(int patient_id)
        {
           
            int LabCharge = 0;
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            command.Parameters.Clear();
            
            //Find Lab charge
            command.CommandText = "SELECT SUM(labs.test_cost) FROM [187057_Akash].labs WHERE labs.patient_id=" + patient_id + "";
            conn.Open();
            var dataReader = command.ExecuteScalar();
            if (dataReader != DBNull.Value)
            {
                LabCharge = Convert.ToInt32(dataReader);
            }
            else
            {
                LabCharge = 0;
            }
            conn.Close();
            command.Dispose();
            SqlCommand command2 = DatabaseHelper.GetCommandObject();
            command2.Parameters.Clear();
            command2.CommandText = "SELECT SUM([187057_Akash].rooms.room_charge) FROM [187057_Akash].rooms WHERE [187057_Akash].rooms.patient_id=" + patient_id + "";
            conn.Open();
            int RoomCharge = 0;
            var rdr = command.ExecuteScalar();
            if(rdr != DBNull.Value)
            {
                RoomCharge = Convert.ToInt32(rdr);
            }
            else
            {
                RoomCharge = 0;
            }

            conn.Close();
            command2.Dispose();

            //Find Doctor Assigned
            SqlCommand command3 = DatabaseHelper.GetCommandObject();
            command3.Parameters.Clear();
            command3.CommandText = "SELECT [187057_Akash].doctors.doctor_name from [187057_Akash].doctors where [187057_Akash].doctors.doctor_id in (SELECT doctor_assigned from [187057_Akash].inpatients where [187057_Akash].inpatients.patient_id=" + patient_id + ")";
            conn.Open();
            SqlDataReader reader2 = command3.ExecuteReader();
            string DoctorAssigned =null;
            while (reader2.Read())
            {
                DoctorAssigned = reader2.GetString(0);
                break;
            }
            conn.Close();
            command3.Dispose();

            Bill bill = new Bill();
            bill.Patient_Id = patient_id;
            bill.LabCharge = LabCharge;
            bill.Doctor_Assigned = DoctorAssigned;
            bill.Bill_Id = id++;

            SqlCommand command4 = DatabaseHelper.GetCommandObject();
            command4.Parameters.Clear();
            //Find patient name
            command4.CommandText = "SELECT name FROM [187057_Akash].patients WHERE patient_id=" + patient_id + "";
            conn.Open();
            string patient_name = command.ExecuteScalar().ToString();
            conn.Close();
            bill.PatientName = patient_name;

            //Find days admitted this will hep us calculate the room charge
            command4.CommandText = "SELECT admission_date from [187057_Akash].inpatients where patient_id=" + patient_id + "";
            conn.Open();
            DateTime admissionDate = Convert.ToDateTime(command.ExecuteScalar());
            double daysAdmitted = (DateTime.Today - admissionDate).TotalDays;
            bill.DaysAdmitted = daysAdmitted;
            conn.Close();
            bill.RoomCharge = Convert.ToInt32(RoomCharge * daysAdmitted);
            int totalCost = bill.LabCharge + bill.RoomCharge;
            bill.TotalCost = totalCost;
            return bill;
        }

        //This method will be used to get the patient name by it's ID
        public static string GetRoomNameById(int room_id)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            string room_name = null;
            command.CommandText = "SELECT * FROM [187057_Akash].rooms WHERE room_id = " + room_id + "";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    room_name = reader.GetString(1);
                }
            }
            conn.Close();
            return room_name;
        }
        //Method for inserting lab report data
        public static bool InsertLabReportData(Lab labData)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            bool isAdded = false;
            command.CommandText = "insert into [187057_Akash].labs values(" + labData.Patient_Id+",'"+labData.TestName+"',"+labData.TestCost+")";
            conn.Open();
            int result = command.ExecuteNonQuery();
            if (result > 0)
                isAdded = true;
            conn.Close();
            return isAdded;
        }
        //Method used to search the InPatient by their ID
        public static InPatients SearchInPatient(int patient_id)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            InPatients inpatient = new InPatients();
            command.CommandText = "SELECT * FROM [187057_Akash].inpatients WHERE patient_id = " + patient_id + "";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inpatient.Patient_Id = reader.GetInt32(0);
                    inpatient.AdmitDate = reader.GetDateTime(1);
                    inpatient.DoctorAssigned = reader.GetInt32(2);
                    inpatient.Disease = reader.GetString(3);
                    inpatient.RoomAssigned = reader.GetInt32(4);
                }
            }
            conn.Close();
            return inpatient;
        }
        //Method to add an InPatient
        public static bool AddInPatients(InPatients inpatient)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            bool isAdded = false;
            command.CommandText = "INSERT INTO [187057_Akash].inpatients VALUES ('" + inpatient.Patient_Id + "', '" + inpatient.AdmitDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + inpatient.DoctorAssigned + "', '" + inpatient.Disease + "', '" + inpatient.RoomAssigned + "');";
            conn.Open();
            int result = command.ExecuteNonQuery();
            
            if (result > 0)
            {
                SqlCommand command2 = DatabaseHelper.GetCommandObject();
                command2.Parameters.Clear();
                command2.Connection = conn;
                command2.Parameters.AddWithValue("@patient_id", inpatient.Patient_Id);
                command2.Parameters.AddWithValue("@room_assigned", inpatient.RoomAssigned);
                command2.CommandText = "UPDATE [187057_Akash].rooms SET patient_id =@patient_id WHERE room_id =@room_assigned;";
                command2.ExecuteNonQuery();
                isAdded = true;
            }
            conn.Close();
            return isAdded;
        }
        //Method to get the list of rooms
        public static List<Room> GetRooms()
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            List<Room> roomList = new List<Room>();
            command.CommandText = "SELECT * FROM [187057_Akash].rooms WHERE patient_id IS NULL";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.Room_Id = reader.GetInt32(0);
                    room.Room_Name = reader.GetString(1);
                    room.Room_Charge = reader.GetInt32(3);
                    roomList.Add(room);
                }
            }
            conn.Close();
            return roomList;
        }
        //Method for getting all doctors
        public static List<Doctors> GetDoctors()
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            List<Doctors> doctorsList = new List<Doctors>();
            command.CommandText = "SELECT * FROM [187057_Akash].doctors";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Doctors doctor = new Doctors();
                    doctor.Doctor_Id = reader.GetInt32(0);
                    doctor.Doctor_Name = reader.GetString(1);
                    doctor.Department = reader.GetString(2);
                    doctorsList.Add(doctor);
                }
            }
            conn.Close();
            return doctorsList;
        }
        //Method for getting patients
        public static List<Patient> GetPatients()
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            List<Patient> patientsList = new List<Patient>();
            command.CommandText = "SELECT max(patient_id) FROM [187057_Akash].patients";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
                if (recordsCount > 0)
            {
                command.CommandText = "Select * from [187057_Akash].patients";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.Patient_Id = reader.GetInt32(0);
                    patient.Name = reader.GetString(1);
                    patient.Age = reader.GetInt32(2);
                    patient.Gender = reader.GetString(3);
                    patient.Address = reader.GetString(4);
                    patientsList.Add(patient);
                }
            }
            conn.Close();
            return patientsList;
        }
        //Method for updating patient's information
        public static bool UpdatePatient(Patient patient)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            bool isUpdated = false;
            command.CommandText = "UPDATE [187057_Akash].patients SET patient_id = '" + patient.Patient_Id + "', name = '" + patient.Name + "', age = '" + patient.Age + "', gender = '" + patient.Gender + "', address = '" + patient.Address + "', phoneNo = '" + patient.Phone + "' WHERE patients.patient_id = " + patient.Patient_Id + ";";
            conn.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                isUpdated = true;
            }
            conn.Close();
            command.Dispose();
            return isUpdated;
        }
        //Method for searchingrun
        public static Patient SearchPatient(int patient_id)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            Patient patientToUpdate = new Patient();
            command.CommandText = "SELECT * FROM [187057_Akash].patients WHERE patient_id = " + patient_id + "";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patientToUpdate.Patient_Id = reader.GetInt32(0);
                    patientToUpdate.Name = reader.GetString(1);
                    patientToUpdate.Age = reader.GetInt32(2);
                    patientToUpdate.Gender = reader.GetString(3);
                    patientToUpdate.Address = reader.GetString(4);
                    patientToUpdate.Phone = reader.GetString(5);

                }
            }
            conn.Close();
            return patientToUpdate;
        }
        //Method for getting patient's name
        public static string GetPatientNameById(int patient_id)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            string patient_name = null;
            command.CommandText = "SELECT * FROM [187057_Akash].patients WHERE patient_id = " + patient_id + "";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patient_name = reader.GetString(1);
                }
            }
            conn.Close();
            return patient_name;
        }
        //Method for Getting the doctor's name by their ID
        public static string GetDoctortNameById(int doc_id)
        {
            SqlConnection conn = DatabaseHelper.GetConnectionObject();
            SqlCommand command = DatabaseHelper.GetCommandObject();
            string doc_name = null;
            command.CommandText = "SELECT * FROM [187057_Akash].doctors WHERE doctor_id = " + doc_id + "";
            conn.Open();
            int recordsCount = Convert.ToInt32(command.ExecuteScalar());
            if (recordsCount > 0)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    doc_name = reader.GetString(1);
                }
            }
            conn.Close();
            return doc_name;
        }
    }
}
