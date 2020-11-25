using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class CaseStatus
    {
        public CaseStatus()
        {
            CaseOrders = new HashSet<CaseOrder>();
        }

        public int CaseStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CaseOrder> CaseOrders { get; set; }
    }
}
