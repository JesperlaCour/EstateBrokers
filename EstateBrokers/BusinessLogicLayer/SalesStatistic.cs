using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence;
using System.Linq;

namespace BusinessLogicLayer
{
    public class SalesStatistic
    {
        IDatabase db;
        public List<SoldHouse> GetSoldHouses(int zipCode,DateTime from,DateTime to)
        {
            db = new DatabaseProxy();
            List<SoldHouse> soldHouses = new List<SoldHouse>();

            foreach (var item in db.GetAllCaseOrders().Where(c => c.CaseStatusId == 3))
            {
                soldHouses.Add(new SoldHouse(item.CaseOrderId, item.EstateId,db.GetBroker(
                    Convert.ToInt32(item.BrokerId)).Name));
            }

            foreach (var item in soldHouses)
            {
                Estate estate = db.GetEstate(item.EstateId);
                item.Address = estate.Address;
                item.SquareMeters = Convert.ToInt32(estate.Areal);
                item.ZipCode = Convert.ToInt32(estate.ZipCode);
                item.SalesPrice = Convert.ToDecimal(db.GetPriceHistory(item.EstateId).Last().Price);
                item.SquareMeterPrice = Math.Round(item.SalesPrice / item.SquareMeters);
                item.SalesDate = Convert.ToDateTime(db.GetPriceHistory(item.EstateId).Last().Date);
            }
            if (zipCode < 0 )
            {
                return soldHouses.Where(s => s.SalesDate > from && s.SalesDate < to).ToList();
            }
            else
                return soldHouses.Where(s => s.ZipCode == zipCode).Where(s => s.SalesDate > from && s.SalesDate < to).ToList();
        }




    }
}
