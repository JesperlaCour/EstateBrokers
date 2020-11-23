using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class HouseType
    {
        public HouseType()
        {
            Estates = new HashSet<Estate>();
        }

        public int TypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
