﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Baggining";
                address.City = "Hobbiton";
                address.State = "Ringland";
                address.Country = "Middle Earth";
                address.PostalCode = "112333";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Baggining",
                City = "Hobbiton",
                State = "Ringland",
                Country = "Middle Earth",
                PostalCode = "112333"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Ringland",
                Country = "Middle Earth",
                PostalCode = "223444"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }

    }
}
