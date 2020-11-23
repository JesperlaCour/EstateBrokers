using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Broker
    {
        public Broker()
        {
            CaseOrders = new HashSet<CaseOrder>();
            OpenHouses = new HashSet<OpenHouse>();
        }

        public int BrokerID { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CaseOrder> CaseOrders { get; set; }
        public virtual ICollection<OpenHouse> OpenHouses { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
