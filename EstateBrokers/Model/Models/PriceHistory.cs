using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class PriceHistory
    {
        public PriceHistory(decimal? price, int? estateId, int? priceTypeId)
        {
            Price = price;
            EstateId = estateId;
            PriceTypeId = priceTypeId;
        }

        public int PriceHistoryId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Date { get; set; }
        public int? EstateId { get; set; }
        public int? PriceTypeId { get; set; }

        public virtual Estate Estate { get; set; }
        public virtual PriceType PriceType { get; set; }
    }
}
