using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Type
    {
        public Type()
        {
            Estates = new HashSet<Estate>();
        }

        public int TypeID { get; set; }
        public string Type1 { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
