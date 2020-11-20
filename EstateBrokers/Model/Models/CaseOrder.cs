using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class CaseOrder
    {
        public CaseOrder()
        {
            OpenHouses = new HashSet<OpenHouse>();
        }

        public int CaseOrderId { get; set; }
        public string CaseStatus { get; set; }
        public int? SellerId { get; set; }
        public int? BrokerId { get; set; }
        public int? EstateId { get; set; }
        public int? BuyerId { get; set; }

        public virtual Broker Broker { get; set; }
        public virtual Customer Buyer { get; set; }
        public virtual Estate Estate { get; set; }
        public virtual Customer Seller { get; set; }
        public virtual ICollection<OpenHouse> OpenHouses { get; set; }
    }
}
