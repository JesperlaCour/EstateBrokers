using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;
using Persistence;


namespace BusinessLogicLayer
{
    public class ListingCalculator
    {
        public decimal? CalculatedPrice(CalculationEntities houseInfo, ref List<Estate> estates)
        {
            IDatabase db = new DatabaseProxy();
            decimal? averageSqm = 0;
            estates = GetEstatesBasedOn_ZipCodeAndHousetype(houseInfo.ZipCode, houseInfo.TypeID, houseInfo.RemodelYear);
            foreach (var item in estates)
            {
                if (db.GetPriceHistory(item.EstateId).Count != 0)
                {
                    averageSqm += db.GetPriceHistory(item.EstateId).Last().Price / item.Areal;
                }

            }
            
            decimal? ListingPrice = averageSqm * houseInfo.SquareMeters;
            
            ListingPrice *= (1 + (houseInfo.Condition / 100));

            if (houseInfo.BathAmount>1)
            {
                ListingPrice += 75000;
            }
            return Math.Round(Convert.ToDecimal(ListingPrice));
        }
        
        private List<Estate> GetEstatesBasedOn_ZipCodeAndHousetype(int zipCode,int houseType, int remodelYear)
        {
            IDatabase db = new DatabaseProxy();
            return db.GetEstatesBasedOn_ZipCodeAndHousetype(zipCode, houseType, remodelYear);
        }
    }
}
