using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class ZipCode
    {
        public ZipCode()
        {
            Customers = new HashSet<Customer>();
            Estates = new HashSet<Estate>();
        }

        public int ZipCode1 { get; set; }
        public string City { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Estate> Estates { get; set; }

        public override string ToString()
        {
            return City;
        }
    }

}
