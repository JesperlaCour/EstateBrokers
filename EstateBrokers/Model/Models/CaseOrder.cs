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

        public CaseOrder(string caseStatus, int? sellerId, int? brokerId, int? estateId)
        {
            CaseStatus = caseStatus;
            SellerId = sellerId;
            BrokerId = brokerId;
            EstateId = estateId;
        }

        public CaseOrder(int caseOrderId, string caseStatus, int? sellerId, int? brokerId, int? estateId, int? buyerId)
        {
            CaseOrderId = caseOrderId;
            CaseStatus = caseStatus;
            SellerId = sellerId;
            BrokerId = brokerId;
            EstateId = estateId;
            BuyerId = buyerId;
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
