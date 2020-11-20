using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;

namespace Controller
{
    public class CaseOrderControllerSingleton
    {
        private static CaseOrderControllerSingleton _instance;

        protected CaseOrderControllerSingleton()
        {
        }
        public static CaseOrderControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new CaseOrderControllerSingleton();
            }
            return _instance;
        }
        public void CreateEstate(Estate estate)
        {
            
        }

        IDatabase db;
        public EstateBrokersContext GetGridEstateData()
        {
            db = new DatabaseProxy();
            return db.GetGridEstateData();
        }

        public void UpdateGridEstateData()
        {
            db.UpdateGridEstateData();
        }
    }
}
