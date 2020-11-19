﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace Model.Models
{
    public partial class Estate
    {
        public Estate()
        {
            CaseOrders = new HashSet<CaseOrder>();
            PriceHistories = new HashSet<PriceHistory>();
        }

        public Estate(int estateId, string address, string type, int buildYear, int remodelYear, int condition,
            int areal, int rooms, int floors, bool garden, int zipCode)
        {
            EstateId = estateId;
            Address = address;
            Type = type;
            BuildYear = buildYear;
            RemodelYear = remodelYear;
            Condition = condition;
            Areal = areal;
            Rooms = rooms;
            Floors = floors;
            Garden = garden;
            ZipCode = zipCode;
        }

        public int EstateId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int? BuildYear { get; set; }
        public int? RemodelYear { get; set; }
        public int? Condition { get; set; }
        public int? Areal { get; set; }
        public int? Rooms { get; set; }
        public int? Floors { get; set; }
        public bool? Garden { get; set; }
        public int? ZipCode { get; set; }

        public virtual ZipCode ZipCodeNavigation { get; set; }
        public virtual ICollection<CaseOrder> CaseOrders { get; set; }
        public virtual ICollection<PriceHistory> PriceHistories { get; set; }
    }
}
