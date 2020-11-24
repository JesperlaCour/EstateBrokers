using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using BusinessLogicLayer;
using Persistence;

namespace Controller
{
    public class ListingCalculatorSingleton
    {
        private static ListingCalculatorSingleton _instance;
        private ListingCalculator calculator = new ListingCalculator();

        protected ListingCalculatorSingleton()
        {
        }
        public static ListingCalculatorSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new ListingCalculatorSingleton();
            }
            return _instance;
        }
        public decimal? CalculatedPrice(CalculationEntities houseInfo,ref List<Estate> estates)
        {
            return calculator.CalculatedPrice(houseInfo,ref estates);
        }

        public List<HouseType> GetHouseTypes()
        {
            IDatabase db = new DatabaseProxy();
            return db.GetHouseTypes();
        }
    }
}
