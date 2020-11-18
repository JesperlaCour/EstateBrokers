﻿using System;
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

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNr { get; set; }
        public int ZipCode { get; set; }

        public virtual ZipCode ZipCodeNavigation { get; set; }
        public virtual ICollection<CaseOrder> CaseOrders { get; set; }
    }
}
