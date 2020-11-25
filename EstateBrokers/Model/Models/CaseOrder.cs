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

        //For search
        //public CaseOrder(int caseOrderId, string caseStatus, int? sellerId, int? brokerId, int? estateId, int? buyerId, string address, int zipCode, string city)
        //{
        //    CaseOrderId = caseOrderId;
        //    CaseStatus = caseStatus;
        //    EstateId = estateId;
        //    Address = address;
        //    ZipCode = zipCode;
        //    City = city;
        //}

        public int CaseOrderId { get; set; }
        public string CaseStatus { get; set; }
        public int? SellerId { get; set; }
        public int? BrokerId { get; set; }
        public int? EstateId { get; set; }
        public int? BuyerId { get; set; }


        //Properties for search use
        //public string Address { get; set; }
        //public int ZipCode { get; set; }
        //public string City { get; set; }

        public virtual Broker Broker { get; set; }
        public virtual Customer Buyer { get; set; }
        public virtual Estate Estate { get; set; }
        public virtual Customer Seller { get; set; }
        public virtual ICollection<OpenHouse> OpenHouses { get; set; }
    }
}
