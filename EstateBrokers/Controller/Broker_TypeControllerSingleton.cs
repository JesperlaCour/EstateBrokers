using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Persistence;

namespace Controller
{
    public class Broker_TypeControllerSingleton
    {
        private static Broker_TypeControllerSingleton _instance;

        protected Broker_TypeControllerSingleton()
        {
        }
        public static Broker_TypeControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Broker_TypeControllerSingleton();
            }
            return _instance;
        }
        EFDatabase db;
        public List<Broker> GetListBrokers()
        {
            db = new EFDatabase();
            return db.GetBrokers().ToList();
        }
        public DbSet<Broker> GetGridBrokers()
        {
            db = new EFDatabase();
            return db.GetBrokers();
        }

        public void UpdateBrokers()
        {
            db.SaveDBContext();
        }
        public DbSet<Model.Models.Type> GetGridType()
        {
            db = new EFDatabase();
            return db.GetTypes();
        }

        public void UpdateType()
        {
            db.SaveDBContext();
        }
    }
}
