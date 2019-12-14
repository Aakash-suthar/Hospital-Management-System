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
    /// Interaction logic for UpdatePatient.xaml
    /// </summary>
    public partial class UpdatePatient : Window
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void GotoDashboard(object sender, RoutedEventArgs e)
        {
            var DashboardWindow = new Dashboard();
            DashboardWindow.Show();
            this.Close();
        }

        private void SearchPatient(object sender, RoutedEventArgs e)
        {
           Patient patient = HospitalBusinessLayer.HospitalBAL.SearchPatient(Convert.ToInt32(search_patient_id_textbox.Text));
            patient_id_textbox.Text = patient.Patient_Id.ToString();
            patient_name_textbox.Text = patient.Name;
            patient_age_textbox.Text = patient.Age.ToString();
            patient_address_textbox.Text = patient.Address;
            patient_gender_textbox.Text = patient.Gender;
            patient_phone_textbox.Text = patient.Phone.ToString();
        }
        private void UpdatePatientInfo(object sender, RoutedEventArgs e)
        {

            Patient patient = null;
            try
            {
                patient = new Patient();
                {

                    patient.Patient_Id = Convert.ToInt32(patient_id_textbox.Text);
                    patient.Name = patient_name_textbox.Text.ToString();
                    patient.Age = Convert.ToInt32(patient_age_textbox.Text);
                    patient.Address = patient_address_textbox.Text;
                    patient.Gender = patient_gender_textbox.Text;
                    patient.Phone = (patient_phone_textbox.Text);
                }
                bool isValid = HospitalBusinessLayer.HospitalBAL.ValidateNewPatient(patient);
                if (isValid)
                {
                    bool isUpdated = HospitalBusinessLayer.HospitalBAL.UpdatePatient(patient);
                    if (isUpdated)
                        MessageBox.Show("Updated!");
                }
            }
            catch (HospitalExceptions.HospitalExceptions exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
