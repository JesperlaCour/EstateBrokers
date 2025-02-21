﻿using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;

namespace Controller
{
    public class EstateControllerSingleton
    {
        private static EstateControllerSingleton _instance;

        protected EstateControllerSingleton()
        {
        }
        public static EstateControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new EstateControllerSingleton();
            }
            return _instance;
        }
        public void CreateEstate(Estate estate)
        {
            IDatabase db = new DatabaseProxy();
            db.CreateEstate(estate);
        }

        IDatabase db;
        public EstateBrokersContext GetGridEstateData(string name)
        {
            db = new DatabaseProxy();
            return db.GetGridEstateData(name);
        }

        public void SaveDBContext()
        {
            db.SaveDBContext();
        }

        public List<Estate> GetEstate(int? estateId)
        {
            db = new DatabaseProxy();
            List<Estate> list = new List<Estate>();
            list.Add(db.GetEstate(estateId));
            return list;
        }

        public List<HouseType> GetHouseTypes()
        {
            db = new DatabaseProxy();
            return db.GetHouseTypes();
        }
    }
}
