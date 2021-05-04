using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACMTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // arrange

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflower",
                Description = "4 yellow flowers",
                CurrentPrice = 15.69M
            };

            // act

            var actual = productRepository.Retrieve(2);


            // assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }

        [TestMethod]
        public void SaveTestValid()
        {
            // arrange

            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 19.44M,
                Description = "4 bright yellow sunflowers",
                ProductName = "Sunflower",
                hasChanges = true
            };

            // act

            var actual = productRepository.Save(updateProduct);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // arrange

            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "4 bright yellow sunflowers",
                ProductName = "Sunflower",
                hasChanges = true
            };

            // act

            var actual = productRepository.Save(updateProduct);

            // assert
            Assert.AreEqual(false, actual);
        }
    }
}
