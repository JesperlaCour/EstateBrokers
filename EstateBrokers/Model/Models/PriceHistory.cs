using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class PriceHistory
    {
        public int PriceHistoryId { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string PriceType { get; set; }
        public int EstateId { get; set; }

        public virtual Estate Estate { get; set; }
    }
}
