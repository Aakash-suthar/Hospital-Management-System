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
    /// Interaction logic for ViewPatientInfo.xaml
    /// </summary>
    public partial class ViewPatientInfo : Window
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public ViewPatientInfo()
        {
            InitializeComponent();
        }

        private void GotoDashboard(object sender, RoutedEventArgs e)
        {
            var DashboardWindow = new Dashboard();
            DashboardWindow.Show();
            this.Close();
        }

        private void GetPatientHistory(object sender, RoutedEventArgs e)
        {
            Patient patient = HospitalBusinessLayer.HospitalBAL.SearchPatient(Convert.ToInt32(patientid.Text));
            patient_id_textbox.Text = patient.Patient_Id.ToString();
            patient_name_textbox.Text = patient.Name;
            patient_age_textbox.Text = patient.Age.ToString();
            patient_gender_textbox.Text = patient.Gender;
            patient_address_textbox.Text = patient.Address;
            patient_phone_textbox.Text = patient.Phone.ToString();
        }
    }
}
