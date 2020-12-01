using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using BusinessLogicLayer;

namespace Controller
{
    public class SalesStatisticControllerSingleton
    {
        private static SalesStatisticControllerSingleton _instance;

        protected SalesStatisticControllerSingleton()
        {
        }
        public static SalesStatisticControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new SalesStatisticControllerSingleton();
            }
            return _instance;
        }

        SalesStatistic sales = new SalesStatistic();
        public List<SoldHouse> GetSoldHouses(int zipCode, DateTime from, DateTime to)
        {
            return sales.GetSoldHouses(zipCode, from, to);
        }
    }
}
