using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }


        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
