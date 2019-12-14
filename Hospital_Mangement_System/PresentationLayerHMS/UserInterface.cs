using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerHMS;
using EntityHMS;

namespace PresentationLayerHMS
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                do
                {
                    Deserialize();
                    Deserializebill();
                    Deserializein();
                    Deserializedoctor();
                    PrintMenu();
                    Console.WriteLine("Enter your Choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            PatientMenu();
                            break;
                        case 2:
                            DoctorMenu();
                            break;
                        case 3:
                            AppointmentMenu();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } while (choice != -1 && choice != 4);

            }
            catch
            {
                Console.WriteLine("Error occured.");
            }
        }


        //Menu
        private static void PrintMenu()
        {
            Console.WriteLine("====================Hospital Management System=================");
            Console.WriteLine("1. Patient Details.");
            Console.WriteLine("2. Doctor Details.");
            Console.WriteLine("3. Appointment");
            Console.WriteLine("4. Quit");
            
        }
        private static void DoctorMenu()
        {
            Console.Clear();
            int a;
            do
            {
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. View Doctor details");
                Console.WriteLine("3. Back");
                Console.WriteLine("Your Choice:");
                 a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        AddDoctor();
                        break;
                    case 2:
                        ShowDoctor();
                        break;
                    default: Console.WriteLine("invalid choice");
                        break;

                }
            } while (a != 3);

        }
        private static void AppointmentMenu()
        {
            Console.Clear();
            Inpatientmenu();
         }
        private static void Inpatientmenu()
        {
            Console.Clear();
            int ch;
            do
            {
                Console.WriteLine("\n_________Details_____________________________________________");
                Console.WriteLine("1. Add Appointment");
                Console.WriteLine("2. View Appointment");
                Console.WriteLine("3. Back");
                
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Enter your Choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Inpatient();
                        break;
                    case 2:
                        InpatientView();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (ch != 3);
        }
        private static void PatientMenu()
        {
            try
            {
                Console.Clear();
                int ch;
                do
                {
                    Console.WriteLine("\n_________Details_____________________________________________");
                    Console.WriteLine("1. Add Patient information");
                    Console.WriteLine("2. Modify patient Information");
                    Console.WriteLine("3. Search Patient Information");
                    Console.WriteLine("4. Medical Bill");
                    Console.WriteLine("5. Back");
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter your Choice:");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            AddPatient();
                            break;
                        case 2:
                            UpdatePatient();
                            break;
                        case 3:
                            SearchPatientByPatientId();
                            break;
                        case 4:
                            BillGenerationMenu();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } while (ch != 5);
            }
            catch
            {
                Console.WriteLine("Error occured.");
            }
        }
        private static void BillGenerationMenu()
        {
            Console.Clear();
            int ch;
            do
            {
                Console.WriteLine("\n____________________________________________________________");
                Console.WriteLine("1. Add Bill");
                Console.WriteLine("2. Generate Bill ");
                Console.WriteLine("3. Back");
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Enter your Choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddBill();
                        break;
                    case 2:
                        MedicalView();
                        break;
                    case 3:

                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (ch != 3);
        }


        //Display
        public static void InpatientView()
        {
            try
            {
                string searchPatientId;
                Console.WriteLine("Enter Patient ID to Search:");
                searchPatientId = Console.ReadLine();
                InpatientAppointment searchPatient = BLL.SearchInPatientBL(searchPatientId);
                if (searchPatient != null)
                {
                    Console.WriteLine("____________________________________________________________________________");
                    Console.WriteLine("Patient Id\t\t Appointment Id\t\t\t Doctor Id");

                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\n\n", searchPatient.PatientId, searchPatient.AppointmentId, searchPatient.DoctorId);
                    
                    Console.WriteLine("Date Of Visitation\t\t Discharge Date\t\t Room Amount");
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\n\n", searchPatient.DateOfVisitation, searchPatient.DischargeDAte, searchPatient.RoomAmount);
                    Console.WriteLine("____________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("No Patient Details Available");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MedicalView()
        {
            try
            {
                string searchPatientId;
                Console.WriteLine("Enter Patient ID to Search:");
                searchPatientId = Console.ReadLine();
                Bill searchPatient = BLL.SearchbillBL(searchPatientId);
                if (searchPatient != null)
                {
                    Console.WriteLine("____________________________________________________________________________");
                    Console.WriteLine("Bill NO\t\t Patient Id \t\tPatient Type\t\t Doctor Id");

                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", searchPatient.BillNo, searchPatient.PatientId, searchPatient.PatientType, searchPatient.DoctorId);
                    Console.WriteLine("____________________________________________________________________________");
                    Console.WriteLine("____________________________________________________________________________");
                    Console.WriteLine("Doctor Fees\t\t Room Charge\t\t Operation charge\t\tMedical Fees\t\t Total days");
                    Console.WriteLine("{0}\t\t\t\t{1}\t\t\t{2}\t\t\t{3}\t\t\t{4}", searchPatient.DoctorFees, searchPatient.RoomCharge,searchPatient.OperationCharge,searchPatient.MedicineFee,searchPatient.TotalDays);
                    Console.WriteLine("Lab Fees\t\t Total");
                    Console.WriteLine("{0}\t\t{1}",searchPatient.LabFees,searchPatient.Total);
                    
                    Console.WriteLine("____________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("No Patient Details Available");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static void ShowDoctor()
        {
            try
            {
                string searchDoctorId;
                List<Doctor> d = BLL.SearchDoctorBL();
                if (d != null)
                {
                    foreach (Doctor search in d)
                    {
                        Console.WriteLine("____________________________________________________________________________");
                        Console.WriteLine("Doctor Id\t\t\t\t\t Doctor Name \t\t\t\t\t Doctor Department");

                        Console.WriteLine("{0}\t\t\t\t\t{1}\t\t\t\t\t\t\t{2}", search.DoctorId, search.DoctorName, search.Dept);

                        Console.WriteLine("____________________________________________________________________________");

                    }
                }
                else
                    Console.WriteLine("No doctor available with this id");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Adding Details
        private static void AddPatient()
        {
            try
            {
                Patient newPatient = new Patient();

                Console.WriteLine("Patient Id     :");
                string id = Console.ReadLine();
                newPatient = BLL.SearchPatientBL(id);
                if (newPatient == null)
                {
                    newPatient.PatientId = id;
                    Console.WriteLine("Name:");
                    newPatient.PatientName = Console.ReadLine();
                    Console.WriteLine("Gender:");
                    newPatient.Gender = Console.ReadLine().ToLower();
                    Console.WriteLine("Age :");
                    newPatient.Age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("weight :");
                    newPatient.Weight = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Address:");
                    newPatient.Address = Console.ReadLine();
                    Console.WriteLine("Phoneno :");
                    newPatient.PhoneNo = Console.ReadLine();
                    Console.WriteLine("Disease:");
                    newPatient.Disease = Console.ReadLine();
                    Console.WriteLine("DoctorId:");
                    newPatient.DoctorId = Console.ReadLine();

                    bool Added = BLL.AddPatientBLL(newPatient);
                    if (Added)
                        Console.WriteLine("Patient is Added");
                    else
                        Console.WriteLine("Patient is not Added");
                }
                else
                    Console.WriteLine("Patient alredy exist...");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void AddDoctor()
        {
            try
            {
                Doctor newDoctor = new Doctor();
                Console.WriteLine("Enter Doctor Details");
                Console.WriteLine("ID :");
                newDoctor.DoctorId = Console.ReadLine();
                Console.WriteLine("Name:");
                newDoctor.DoctorName = Console.ReadLine();
                Console.WriteLine("Department:");
                newDoctor.Dept = Console.ReadLine();

                bool Added = BLL.AddDOctorBLL(newDoctor);
                if (Added)
                    Console.WriteLine("Doctor is Added");
                else
                    Console.WriteLine("Doctor is not Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

      
        private static void AddBill()
        {
            try
            {
                
                
                Bill newbill = new Bill();
                Console.WriteLine("Enter Bill Details");
                Console.WriteLine("Bill ID :");
                newbill.BillNo = Console.ReadLine();
                Console.WriteLine("Patient ID :");
                newbill.PatientId = Console.ReadLine();
                Console.WriteLine("Doctor Id :");
                newbill.DoctorId = Console.ReadLine();
                if(newbill.PatientType=="Inpatient")
                {
                    Console.WriteLine("Room charges :");
                    newbill.RoomCharge = double.Parse(Console.ReadLine());

                }
                else
                {
                    newbill.RoomCharge = 0;
                }
                Console.WriteLine("Doctor Fees :");
                newbill.DoctorFees = double.Parse(Console.ReadLine());
                Console.WriteLine("Operation Charge :");
                newbill.OperationCharge = double.Parse(Console.ReadLine());
                Console.WriteLine("Medicine Fees:");
                newbill.MedicineFee = double.Parse(Console.ReadLine());
                Console.WriteLine("Lab Fees :");
                newbill.LabFees = double.Parse(Console.ReadLine());
                newbill.Total = newbill.RoomCharge + newbill.DoctorFees + newbill.OperationCharge + newbill.MedicineFee + newbill.LabFees;

                bool Added = BLL.AddBillBLL(newbill);
                if (Added)
                    Console.WriteLine("Patient is Added");
                else
                    Console.WriteLine("Patient is not Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static void Inpatient()
        {
            try
            {
                InpatientAppointment app = new InpatientAppointment();
                Patient p = new Patient();
                Console.WriteLine("Patient Id     :");

                string id =Console.ReadLine();
                p = BLL.SearchPatientBL(id);
                if (p != null)
                {
                    app.PatientId = id;
                    Console.WriteLine("Appointment ID :");
                    app.AppointmentId = Console.ReadLine();
                    Console.WriteLine("Doctor Id     :");
                    app.DoctorId = (Console.ReadLine());
                    Console.WriteLine("Visitation Date :");
                    app.DateOfVisitation = Console.ReadLine();
                    Console.WriteLine("Admission DAte :");
                    app.AdmissionDate = Console.ReadLine();
                    Console.WriteLine("Discharge Date");
                    app.DischargeDAte = Console.ReadLine();
                    Console.WriteLine("Room Amount");
                    app.RoomAmount = int.Parse(Console.ReadLine());
                    bool Added = BLL.AddInpatient(app);
                    if (Added)
                        Console.WriteLine("Appointment Added");
                    else
                        Console.WriteLine("Appointment not Added");
                }
                else
                    Console.WriteLine("first enter patient details before in a system.. ");
                
               



               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        //Deserializing data
         public static void Deserialize()
        {
           BLL.bllD();
        }
        public static void Deserializebill()
        {
            BLL.billbll();
        }
        public static void Deserializein()
        {
            BLL.inpatientbll();
            
        }
        public static void Deserializedoctor()
        {
            BLL.doctord();
        }


        //update
        private static void UpdatePatient()
        {
            try
            {
                string updatePatientId;
                Console.WriteLine("Enter Patient ID to Update Details:");
                updatePatientId = Console.ReadLine();
                Patient updatedPatient = BLL.SearchPatientBL(updatePatientId);
                if (updatedPatient != null)
                {
                    Console.WriteLine("Name :");
                    updatedPatient.PatientName = Console.ReadLine();
                    Console.WriteLine("Age:");
                    updatedPatient.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Weight:");
                    updatedPatient.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gender :");
                    updatedPatient.Gender = Console.ReadLine();
                    Console.WriteLine("Address :");
                    updatedPatient.Address = Console.ReadLine();
                    Console.WriteLine("Phone Number:");
                    updatedPatient.PhoneNo = Console.ReadLine();
                    Console.WriteLine("Disease :");
                    updatedPatient.Disease = Console.ReadLine();
                    Console.WriteLine("Doctor Id :");
                    updatedPatient.DoctorId = Console.ReadLine();

                    bool patientUpdated = BLL.UpdatePatientBL(updatedPatient);
                    if (patientUpdated)
                        Console.WriteLine("Patient Details are Updated");
                    else
                        Console.WriteLine("Patient Details are not Updated ");
                }
                else
                {
                    Console.WriteLine("No Patient Details are Available");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //search
        private static void SearchPatientByPatientId()
        {
            try
            {
                Console.WriteLine("1.By Name");
                Console.WriteLine("2.By Age");
                Console.WriteLine("3.By Patient Id");
                Console.WriteLine("4.By Weight");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name to Search:");
                        string name = Console.ReadLine();
                        SearchPatient(BLL.SearchPatientBLListreturnname(name));
                        break;
                    case 2:
                        Console.WriteLine("Enter Age to Search:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        SearchPatient(BLL.SearchPatientBLListreturnage(age));
                        break;
                    case 3:
                        Console.WriteLine("Enter Patient ID to Search:");
                        string searchPatientId = Console.ReadLine();
                        SearchPatient(BLL.SearchPatientBLListreturn(searchPatientId));
                        break;
                    case 4:
                        Console.WriteLine("Enter Patient Weight to Search:");
                        int w = Convert.ToInt32(Console.ReadLine());
                        SearchPatient(BLL.SearchPatientBLListreturnweight(w));
                        break;
                    default:
                        break;
                }
            
                //else
                //{
                //    Console.WriteLine("No Patient Details Available");
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void SearchPatient(List<Patient> p)
        {
            try
            {
                //InpatientAppointment searchPatient = BLL.SearchInPatientBL(searchPatientId);
                if (p!=null)
                {
                    foreach(Patient searchPatient in p)
                    {
                        Console.WriteLine("____________________________________________________________________________");
                        Console.WriteLine("Name\t\tAge\t\tWeight\t\tGender\t\tAddress\t\tPhoneNo\t\tDisease\t\tDoctorId");

                        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}", searchPatient.PatientName, searchPatient.Age, searchPatient.Weight, searchPatient.Gender, searchPatient.Address, searchPatient.PhoneNo, searchPatient.Disease, searchPatient.DoctorId);
                        Console.WriteLine("____________________________________________________________________________");

                    }
                }
                else
                {
                    Console.WriteLine("No Patient Details Available");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ViewHistory()
        {

            try
            {
                string searchPatientId;
                Console.WriteLine("Enter Patient ID to Search:");
                searchPatientId = Console.ReadLine();
                InpatientAppointment searchPatient = BLL.SearchInPatientBL(searchPatientId);
                if (searchPatient != null)
                {
                    Console.WriteLine("____________________________________________________________________________");
                    Console.WriteLine("Patient Id\t\t Appointment Id\t\t Doctor Id");

                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\n\n", searchPatient.PatientId, searchPatient.AppointmentId, searchPatient.DoctorId);

                    Console.WriteLine("Date Of Visitation\t\t Discharge Date\t\t Room Amount");
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\n\n", searchPatient.DateOfVisitation, searchPatient.DischargeDAte, searchPatient.RoomAmount);
                    Console.WriteLine("____________________________________________________________________________");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
