using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class SoldHouse
    {
        

        public SoldHouse(int? caseOrderId, int? estateId,string brokerName)
        {
            CaseOrderId = Convert.ToInt32(caseOrderId);
            EstateId = Convert.ToInt32(estateId);
            BrokerName = brokerName;
        }

        public int CaseOrderId { get; set; }
        public int EstateId { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public int SquareMeters { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal SquareMeterPrice { get; set; }
        public int MyProperty { get; set; }
        public DateTime SalesDate { get; set; }
        public string BrokerName { get; set; }




    }
}
