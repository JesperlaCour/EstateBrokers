using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class OpenHouse
    {
        public int OpenHouseId { get; set; }
        public DateTime? Date { get; set; }
        public int? BrokerId { get; set; }
        public int? CaseId { get; set; }

        public virtual Broker Broker { get; set; }
        public virtual CaseOrder Case { get; set; }
    }
}
