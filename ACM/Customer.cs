using Acme.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Customer:EntityBase,ILoggable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public override string ToString() => FullName;

        public static int InstanceCount { get; set; }

        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        // validates customer data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))  isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))  isValid = false;

            return isValid;
        }

        public string Log() => $"{CustomerId} :{FullName} Email: {EmailAddress} Status: something?!?!?";
    }
}
