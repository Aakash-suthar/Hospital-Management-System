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
    /// Interaction logic for GenerateLabReport.xaml
    /// </summary>
    public partial class GenerateLabReport : Window
    {
        private void GotoDashboard(object sender, RoutedEventArgs e)
        {
            var DashboardWindow = new Dashboard();
            DashboardWindow.Show();
            this.Close();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public GenerateLabReport()
        {
            InitializeComponent();
        }

        private void SaveLabTestData(object sender, RoutedEventArgs e)
        {
            Lab labData = new Lab();
            labData.Patient_Id = Convert.ToInt32(patientid.Text);
            labData.TestName = test_name_textbox.Text;
            labData.TestCost = Convert.ToInt32(test_cost_textbox.Text);
            bool isAdded = HospitalBusinessLayer.HospitalBAL.InsertLabReportData(labData);
            if (isAdded)
            {
                MessageBox.Show("Lab Data Added!");
            }
            else
            {
                MessageBox.Show("Unable to add");
            }
        }
    }
}
