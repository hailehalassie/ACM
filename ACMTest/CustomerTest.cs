using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACMTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            // Action
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            // Action
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            // Action
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // Action


            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@gmail.com"
            };

            var excepted = true;

            // Action
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(excepted, actual);
        }


        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer()
            {
                EmailAddress = "fbaggins@gmail.com"
            };

            var excepted = false;

            // Action
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
