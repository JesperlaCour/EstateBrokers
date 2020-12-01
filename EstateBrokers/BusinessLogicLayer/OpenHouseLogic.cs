using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence;
using System.Linq;

namespace BusinessLogicLayer
{
    public class OpenHouseLogic
    {
        List<OpenHouse> openHouses;
        public void AssignOpenHouses(List<CaseOrder> cases, List<Broker> brokers,DateTime date)
        {
            openHouses = new List<OpenHouse>();
            AddPriceToCaseOrder(ref cases);
            cases = cases.OrderByDescending(c => c.lastPrice).ToList();

            int j = 0;
            for (int i = 0; i <= brokers.Count; i++)
            {
                if (i < brokers.Count)
                {
                    openHouses.Add(new OpenHouse(date, brokers[i].BrokerId, cases[j].CaseOrderId));
                    j++;
                }
                else
                    i = -1;
                if (j >= cases.Count())
                {
                    break;
                }
            }
            SaveOpenHouses(openHouses);
        }

        private void SaveOpenHouses(List<OpenHouse> openHouses)
        {
            foreach (var item in openHouses)
            {
                IDatabase db = new DatabaseProxy();
                db.CreateOpenHouse(item);
            }
        }

        private void AddPriceToCaseOrder(ref List<CaseOrder> cases)
        {
            IDatabase db = new DatabaseProxy();
            foreach (var item in cases)
            {
                item.lastPrice = Convert.ToDecimal(db.GetPriceHistory(item.EstateId).Last().Price);
            }
        }

    }
}
