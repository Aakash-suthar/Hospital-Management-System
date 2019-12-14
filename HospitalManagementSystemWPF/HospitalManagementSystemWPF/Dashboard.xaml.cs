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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void AddPatient(object sender, RoutedEventArgs e)
        {
            var AddPatientWindow = new AddPatient();
            AddPatientWindow.Show();
            this.Close();
        }

        private void UpdatePatient(object sender, RoutedEventArgs e)
        {
            var UpdatePatientWindow = new UpdatePatient();
            UpdatePatientWindow.Show();
            this.Close();
        }

        private void AddTreatmentInfo(object sender, RoutedEventArgs e)
        {
            var TreatmentInfoWindow = new AddPatientTreatmentInfo();
            TreatmentInfoWindow.Show();
            this.Close();
        }

        private void ViewPatientInfo(object sender, RoutedEventArgs e)
        {
            var ViewPatientInfoWindow = new ViewPatientInfo();
            ViewPatientInfoWindow.Show();
            this.Close();
        }

      
        private void GenerateLabReport(object sender, RoutedEventArgs e)
        {
            var GenerateLabReportWindow = new GenerateLabReport();
            GenerateLabReportWindow.Show();
            this.Close();
        }

        private void GenerateBills(object sender, RoutedEventArgs e)
        {
            var GenerateBillWindow = new GenerateBill();
            GenerateBillWindow.Show();
            this.Close();
        }
    }
}
