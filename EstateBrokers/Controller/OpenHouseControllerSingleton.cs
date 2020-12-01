using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using BusinessLogicLayer;

namespace Controller
{
    public class OpenHouseControllerSingleton
    {
        private static OpenHouseControllerSingleton _instance;

        protected OpenHouseControllerSingleton()
        {
        }
        public static OpenHouseControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new OpenHouseControllerSingleton();
            }
            return _instance;
        }

        public void AssignOpenHouses(List<CaseOrder> cases, List<Broker> brokers, DateTime date)
        {
            OpenHouseLogic houseLogic = new OpenHouseLogic();
            houseLogic.AssignOpenHouses(cases, brokers, date);
        }

        public void GetOpenHouses(DateTime date)
        {

        }

        public List<DateTime> GetDatesForOpenHouses()
        {
            throw new NotImplementedException();
        }
    }
}
