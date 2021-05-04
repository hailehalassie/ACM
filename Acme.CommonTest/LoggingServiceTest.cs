using ACM;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Reke",
                Description = "Garden reke with steel hand",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //act
            LoggingService.WriteToFile(changedItems);

            //assert
        }
    }
}
