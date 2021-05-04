using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product();

            if (productId == 2)
            {
                product.ProductName = "Sunflower";
                product.Description = "4 yellow flowers";
                product.CurrentPrice = 15.69M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {myObject.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var succes = true;

            if (product.hasChanges)
            {
                if (product.isValid)
                {
                    if (product.isNew)
                    {
                        // insert something
                    }
                    else
                    {
                        // update
                    }
                }
                else
                {
                    succes = false;
                }
            }

            return succes;
        }
    }
}
