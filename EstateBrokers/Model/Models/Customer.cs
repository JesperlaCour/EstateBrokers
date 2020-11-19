using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CaseOrders = new HashSet<CaseOrder>();
        }

       
        public Customer(string name, string address, int phoneNr, int zipCode)
        {
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            ZipCode = zipCode;
        }

        public Customer(int customerId, string name, string address, int phoneNr, int zipCode)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            ZipCode = zipCode;
        }

        public int CustomerId { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public int PhoneNr { get; private set; }
        public int ZipCode { get; private set; }

        public virtual ZipCode ZipCodeNavigation { get; set; }
        public virtual ICollection<CaseOrder> CaseOrders { get; set; }
    }
}
