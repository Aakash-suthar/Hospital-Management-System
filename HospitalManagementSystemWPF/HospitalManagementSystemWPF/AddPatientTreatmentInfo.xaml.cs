using HospitalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for AddPatientTreatmentInfo.xaml
    /// </summary>

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public partial class AddPatientTreatmentInfo : Window
    {
        public AddPatientTreatmentInfo()
        {
            InitializeComponent();
           

            var doctorsList = HospitalBusinessLayer.HospitalBAL.GetDoctors();
            foreach (var doctor in doctorsList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = doctor.Doctor_Name;
                item.Value = Convert.ToInt32(doctor.Doctor_Id);
                doctor_assigned_textbox.Items.Add(item);
            }

            var roomsList = HospitalBusinessLayer.HospitalBAL.GetRooms();
            foreach (var room in roomsList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = room.Room_Name;
                item.Value = Convert.ToInt32(room.Room_Id);
                room_assigned_textbox.Items.Add(item);
            }
        }
        

        private void AddInpatientInfo(object sender, RoutedEventArgs e)
        {
            InPatients inpatient = new InPatients();
            try
            {
                inpatient.Patient_Id = Convert.ToInt32(patientid.Text);
                inpatient.AdmitDate = Convert.ToDateTime(admission_date_textbox.Text.ToString());
                inpatient.DoctorAssigned = Convert.ToInt32((doctor_assigned_textbox.SelectedItem as ComboboxItem).Value);
                inpatient.Disease = Convert.ToString(disease_textbox.Text.ToString());
                inpatient.RoomAssigned = Convert.ToInt32((room_assigned_textbox.SelectedItem as ComboboxItem).Value);
                bool isAdded = HospitalBusinessLayer.HospitalBAL.AddInPatient(inpatient);
                if (isAdded)
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Unable to add");
                }
            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void GotoDashboard(object sender, RoutedEventArgs e)
        {
            var DashboardWindow = new Dashboard();
            DashboardWindow.Show();
            this.Close();
        }
    }
}
