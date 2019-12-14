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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HospitalManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for AddPatient.xaml
    /// </summary>
    public partial class AddPatient : Window
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddNewPatient(object sender, RoutedEventArgs e)
        {
            Patient patient = null;
            try
            {
                patient = new Patient()
                {
                    Name = name.Text,
                    Age = Convert.ToInt32(age.Text),
                    Gender = ((ComboBoxItem)gender.SelectedItem).Content as string,
                    Address = address.Text,
                    Phone = (phone.Text)
                };
                bool isValid=HospitalBusinessLayer.HospitalBAL.ValidateNewPatient(patient);
                if (isValid)
                {
                    bool isAdded = HospitalBusinessLayer.HospitalBAL.AddPatient(patient);
                    if (isAdded)
                    {
                        MessageBox.Show("Patient Added!");
                    }
                }
            }
            catch(HospitalExceptions.HospitalExceptions exp)
            {
                MessageBox.Show(exp.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
