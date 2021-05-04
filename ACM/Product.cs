using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Product : EntityBase, ILoggable
    {
        private string _productName;
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductName 
        {
            get
            {

                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;

        public string Log() => 
            $"{ProductId} :{ProductName} Detail: {Description} Status: something?!?!?";


    }
}
