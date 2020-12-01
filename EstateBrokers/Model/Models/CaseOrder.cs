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

        public CaseOrder(int? caseStatusId,int? sellerId, int? brokerId, int? estateId)
        {
            CaseStatusId = caseStatusId;
            SellerId = sellerId;
            BrokerId = brokerId;
            EstateId = estateId;
        }

        public CaseOrder(int caseOrderId, int? sellerId, int? brokerId, int? estateId, int? buyerId, int? caseStatusId)
        {
            CaseOrderId = caseOrderId;
            SellerId = sellerId;
            BrokerId = brokerId;
            EstateId = estateId;
            BuyerId = buyerId;
            CaseStatusId = caseStatusId;
        }

        public int CaseOrderId { get; set; }
        public int? SellerId { get; set; }
        public int? BrokerId { get; set; }
        public int? EstateId { get; set; }
        public int? BuyerId { get; set; }
        public int? CaseStatusId { get; set; }

        public decimal lastPrice;


        public virtual Broker Broker { get; set; }
        public virtual Customer Buyer { get; set; }
        public virtual CaseStatus CaseStatus { get; set; }
        public virtual Estate Estate { get; set; }
        public virtual Customer Seller { get; set; }
        public virtual ICollection<OpenHouse> OpenHouses { get; set; }
    }
}
