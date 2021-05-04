using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        public AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer();

            if (customerId == 1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "fbaggins@gmail.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
