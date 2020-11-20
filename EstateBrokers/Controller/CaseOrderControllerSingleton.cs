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
        public void CreateCaseOrder(CaseOrder caseOrder, decimal price)
        {
            IDatabase db = new DatabaseProxy();
            db.CreateCaseOrder(caseOrder);
            db.InsertPrice(new PriceHistory(price,"ListingPrice",caseOrder.EstateId));

        }

        
    }
}
