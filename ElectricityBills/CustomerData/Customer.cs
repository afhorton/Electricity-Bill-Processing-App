using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // private data
        const decimal ADMIN_CHARGE = 12m; // always charged even if they didn't use any.
        const decimal KWH_CHARGE = 0.07m; // per hour
        private static int nextAccountNo = 100;
        private int accountNo;
        private string firstName;
        private string lastName;
        private decimal kWhUsed;
        private decimal billAmount;


        // read-only properties 
        public int AccountNo { get { return accountNo; }}
        public decimal BillAmount { get { return billAmount; } set { billAmount = value; } }

        // constructor
        public Customer (string firstName, string lastName, decimal kWhUsed)
        {
            accountNo = nextAccountNo;
            nextAccountNo++;

            this.firstName = firstName;
            this.lastName = lastName;
            this.kWhUsed  = kWhUsed;
            BillAmount = CalculateCharge(kWhUsed);
           

        }

        public decimal CalculateCharge(decimal kWhUsed)
        {   
            if (kWhUsed == 0 || kWhUsed < 0)
            {

                return ADMIN_CHARGE;

            } else
            {
                return Math.Round((kWhUsed * KWH_CHARGE) + ADMIN_CHARGE, 2);
                
            }
        }


        // ToString() method for display
        public override string ToString()
        {
            return $"Account #: {accountNo.ToString().PadRight(25)} (Full Name:) {firstName} {lastName}, (kWh:) {kWhUsed.ToString()}, (Bill Amount:) {BillAmount.ToString("c")}";
        }
    }
}
