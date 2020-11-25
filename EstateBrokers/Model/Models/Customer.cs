using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CaseOrderBuyers = new HashSet<CaseOrder>();
            CaseOrderSellers = new HashSet<CaseOrder>();
        }

        public Customer(string name, string address, int? phoneNr, int? zipCode)
        {
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            ZipCode = zipCode;
        }

        public Customer(int customerId, string name, string address, int? phoneNr, int? zipCode)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            ZipCode = zipCode;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? PhoneNr { get; set; }
        public int? ZipCode { get; set; }

        public virtual ZipCode ZipCodeNavigation { get; set; }
        public virtual ICollection<CaseOrder> CaseOrderBuyers { get; set; }
        public virtual ICollection<CaseOrder> CaseOrderSellers { get; set; }
    }
}
