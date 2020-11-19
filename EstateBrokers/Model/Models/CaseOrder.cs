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

        public CaseOrder(int caseId, string caseStatus, int customerId, int brokerId, int estateId)
        {
            CaseOrderId = caseId;
            CaseStatus = caseStatus;
            CustomerId = customerId;
            BrokerId = brokerId;
            EstateId = estateId;
        } 
        public int CaseOrderId { get; set; }
        public string CaseStatus { get; set; }
        public int? CustomerId { get; set; }
        public int? BrokerId { get; set; }
        public int? EstateId { get; set; }

        public virtual Broker Broker { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Estate Estate { get; set; }
        public virtual ICollection<OpenHouse> OpenHouses { get; set; }
    }
}
