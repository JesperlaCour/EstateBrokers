using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Department
    {
        public Department()
        {
            Brokers = new HashSet<Broker>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Broker> Brokers { get; set; }
    }
}
