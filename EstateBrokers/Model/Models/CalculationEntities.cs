using System;
using System.Collections.Generic;
using System.Text;
public enum Style
{
    Modern,
    Original,
}
namespace Model.Models
{
    public class CalculationEntities
    {
        public CalculationEntities(int typeID, int zipCode, int squareMeters, int condition, int remodelYear, int bathAmount)
        {
            TypeID = typeID;
            ZipCode = zipCode;
            SquareMeters = squareMeters;
            Condition = condition;
            //Style = style;
            RemodelYear = remodelYear;
            BathAmount = bathAmount;
        }

        public int TypeID { get; set; }
        public int ZipCode { get; set; }
        public int SquareMeters { get; set; }
        public decimal Condition { get; set; }
        public Style Style { get; set; }
        public int RemodelYear { get; set; }
        public int BathAmount { get; set; }



    }
}
