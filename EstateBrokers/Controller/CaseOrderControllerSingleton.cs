﻿using Microsoft.EntityFrameworkCore;
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

        public void CreateCaseOrder(CaseOrder caseOrder,int priceTypeID, decimal price)
        {
            IDatabase db = new DatabaseProxy();
            db.CreateCaseOrder(caseOrder);
            db.InsertPrice(new PriceHistory(price,caseOrder.EstateId,priceTypeID));
        }

        public CaseOrder GetCaseOrder(int caseOrderID)
        {
            IDatabase db = new DatabaseProxy();
            return db.GetCaseOrder(caseOrderID);
        }

        public List<CaseOrder> GetAllCaseOrdrsForSearchByAddress(string address)
        {
            IDatabase db = new DatabaseProxy();
            return db.GetAllCaseOrdrsForSearchByAddress(address);
        }

        public List<PriceHistory> GetPriceHistory(int? estateId)
        {
            IDatabase db = new DatabaseProxy();
            return db.GetPriceHistory(estateId);
        }


        public List<CaseStatus> GetCaseStatuses()
        {
            IDatabase db = new DatabaseProxy();
            return db.GetCaseStatuses();
        }

        public void UpdateCaseOrderStatus(CaseOrder co)
        {
            IDatabase db = new DatabaseProxy();
            db.UpdateCaseOrderStatus(co);
        }

        public void CreateNewPriceHistory(PriceHistory priceHistory)
        {
            IDatabase db = new DatabaseProxy();
            db.InsertPrice(priceHistory);
        }
    }
}
