using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
    
    public interface IDatabase
    {
        //Create
        public void CreateCustomer(Customer customer);
        public void CreateEstate(Estate estate);
        public void CreateCaseOrder(CaseOrder caseOrder);

        //Read
        public Customer GetCustomer(int? customerID);
        public List<Customer> GetAllCustomer(string name);

        public Estate GetEstate(int? EstateID);
        public List<Estate> GetAllEstates(string address);

        public CaseOrder GetCaseOrder(int CaseOrderID);
        public List<CaseOrder> GetAllCaseOrders();
        void InsertPrice(PriceHistory priceHistory);


        

        //DataGridView

        public EstateBrokersContext GetGridCustomerData(string name);
      
        
        public EstateBrokersContext GetGridEstateData(string address);
     
        public void SaveDBContext();

        public List<PriceHistory> GetPriceHistory(int? estateId);
        ZipCode GetCityFromZipCode(int? zipCode);
    }
}
