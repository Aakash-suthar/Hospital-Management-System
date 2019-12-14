using HospitalEntities;
using System;
using System.Windows;

namespace HospitalManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for GenerateBill.xaml
    /// 
    /// </summary>
    public partial class GenerateBill : Window
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

        public GenerateBill()
        {
            InitializeComponent();
        }
        private void GotoDashboard(object sender, RoutedEventArgs e)
        {
            var DashboardWindow = new Dashboard();
            DashboardWindow.Show();
            this.Close();
        }

        private void GenerateBillData(object sender, RoutedEventArgs e)
        {
            int patient_id = Convert.ToInt32(searchid.Text);
              //  (patient_id_combobox.SelectedValue as ComboboxItem).Value;
           // int medicine_cost = Convert.ToInt32(medicine_cost_textbox.Text);
         //   int bill_id = Convert.ToInt32(bill_id_textbox.Text);

            Bill bill = HospitalBusinessLayer.HospitalBAL.GenerateBill(patient_id);
            if (bill != null)
            {
                MessageBox.Show("Bill Generated!");
                bill_id_show.Text = bill.Bill_Id.ToString();
                patient_id_show.Text = bill.Patient_Id.ToString();
                doctor_assigned.Text = bill.Doctor_Assigned.ToString();
                room_charge.Text = bill.RoomCharge.ToString();
                lab_charge.Text = bill.LabCharge.ToString();
                days_admitted.Text = bill.DaysAdmitted.ToString();
                total_cost.Text = bill.TotalCost.ToString();
                patient_name.Text = bill.PatientName.ToString();
            }
            else
            {
                MessageBox.Show("Unable to generate bill :(");
            }
        }
    }
}
