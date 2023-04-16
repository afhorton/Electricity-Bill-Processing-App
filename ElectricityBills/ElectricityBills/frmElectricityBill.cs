using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking;
using CustomerData;

namespace ElectricityBills
{
    
    public partial class frmElectricityBills : Form
    {
        // list of customers
        List<Customer> customers = new List<Customer>();

        decimal totalKWH;

        decimal totalBill;
        decimal nrOfBills = 0;
        decimal avgBill;

        Customer newCustomer;

        public frmElectricityBills()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;
            decimal hours;
            

            if (Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtKWHused) &&
                Validator.IsNonNegativeDecimal(txtKWHused))
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                hours = Convert.ToDecimal(txtKWHused.Text);
                

                totalKWH += hours;

                newCustomer = new Customer (firstName, lastName, hours);
                customers.Add(newCustomer);


                // Calculate average bill price
                



                totalBill += newCustomer.BillAmount;
                nrOfBills++;
                avgBill = CalculateAvgBill();

                DisplayCustomers();
                ClearEntries();



            }
        }

        private decimal CalculateAvgBill()
        {
            return totalBill / nrOfBills;
        }

        async private void ClearEntries()
        {
            await Task.Delay(500);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtKWHused.Clear();
            txtBillAmount.Clear();
        }

        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers) 
            {
                lstCustomers.Items.Add(c); 
            }

            txtBillAmount.Text = newCustomer.BillAmount.ToString();
            txtTotalCustomers.Text = customers.Count.ToString();
            txtTotalKWH.Text = totalKWH.ToString();
            txtAverageBill.Text = avgBill.ToString();

        }
    }
}
