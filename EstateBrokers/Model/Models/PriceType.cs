using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class PriceType
    {
        public PriceType()
        {
            PriceHistories = new HashSet<PriceHistory>();
        }

        public int PriceTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PriceHistory> PriceHistories { get; set; }
    }
}
