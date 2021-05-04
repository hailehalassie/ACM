using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACMTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            // act

            var actual = customerRepository.Retrieve(1);

            // assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    { 
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Baggining",
                        City = "Hobbiton",
                        State = "Ringland",
                        Country = "Middle Earth",
                        PostalCode = "112333"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Ringland",
                        Country = "Middle Earth",
                        PostalCode = "223444"
                    }
                }
            
            };

            // act

            var actual = customerRepository.Retrieve(1);

            // assert

            
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            }

        }
    }
}
