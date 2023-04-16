using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargeTestWithZeroKWH()
        {
            // Arrange
            decimal KWH = 0m;
            decimal ActualCharge;
            decimal ExpectedCharge = 12m;

            // Act
            Customer cust = new Customer("Ryan", "Jules", KWH);
            ActualCharge = cust.CalculateCharge(KWH);

            // Assert
            Assert.AreEqual(ExpectedCharge, ActualCharge);

        }

        [TestMethod()]
        public void CalculateChargeTestWithNegativeKWH()
        {
            // Arrange
            decimal KWH = -100m;
            decimal ActualCharge;
            decimal ExpectedCharge = 12m;

            // Act
            Customer cust = new Customer("Ryan", "Jules", KWH);
            ActualCharge = cust.CalculateCharge(KWH);

            // Assert
            Assert.AreEqual(ExpectedCharge, ActualCharge);

        }

        [TestMethod()]
        public void CalculateChargeTestWithKWH()
        {
            // Arrange
            decimal KWH = 100m;
            decimal ActualCharge;
            decimal ExpectedCharge = 19m;

            // Act
            Customer cust = new Customer("Ryan","Jules", KWH);
            ActualCharge = cust.CalculateCharge(KWH);

            // Assert
            Assert.AreEqual(ExpectedCharge, ActualCharge);

        }

    }
}