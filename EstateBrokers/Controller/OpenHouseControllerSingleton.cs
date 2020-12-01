using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using BusinessLogicLayer;
using Persistence;

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
        IDatabase db;
        public List<OpenHouse> GetOpenHouses(DateTime date)
        {
            db = new DatabaseProxy();
            return db.GetOpenHouses(date);
        }

        public List<DateTime?> GetDatesForOpenHouses()
        {
            db = new DatabaseProxy();
            return db.GetDatesForOpenHouses();
        }
        public void SaveDBContext()
        {
            db.SaveDBContext();
        }
    }
}
