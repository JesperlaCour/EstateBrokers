using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
    public class DatabaseProxy : IDatabase
    {
       
        public void CreateCustomer(Customer customer)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                ef.CreateCustomer(customer);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                sql.CreateCustomer(customer);
                
            }
        }

        public void CreateEstate(Estate estate)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                ef.CreateEstate(estate);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                sql.CreateEstate(estate);
            }
           
        }
        public void CreateCaseOrder(CaseOrder caseOrder)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                ef.CreateCaseOrder(caseOrder);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                sql.CreateCaseOrder(caseOrder);
            }
        }


        public List<CaseOrder> GetAllCaseOrders()
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetAllCaseOrders();
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetAllCaseOrders();
            }
        }

        public List<Customer> GetAllCustomer(string name)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetAllCustomer(name);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetAllCustomer(name);
            }
        }

        public List<Estate> GetAllEstates(string address)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetAllEstates(address);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetAllEstates(address);
            }
        }

        public CaseOrder GetCaseOrder(int CaseOrderID)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetCaseOrder(CaseOrderID);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetCaseOrder(CaseOrderID);
            }
        }

        public Customer GetCustomer(int? customerID)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetCustomer(customerID);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetCustomer(customerID);
            }
        }

        public Estate GetEstate(int EstateID)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                return ef.GetEstate(EstateID);
            }
            catch (Exception)
            {
                SqlDatabase sql = new SqlDatabase();
                return sql.GetEstate(EstateID);
            }
        }


        //Admin menu (edit/delete)
        EFDatabase db;
        public EstateBrokersContext GetGridCustomerData(string name)
        {
            db = new EFDatabase();
            try
            {
                return db.GetGridCustomerData(name);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        

        public EstateBrokersContext GetGridEstateData(string address)
        {
            db = new EFDatabase();
            try
            {
                return db.GetGridEstateData(address);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        

        public void InsertPrice(PriceHistory priceHistory)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                ef.InsertPrice(priceHistory);
               
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public void SaveDBContext()
        {
            db.SaveDBContext();
        }

        public Estate GetEstate(int? EstateID)
        {
            try
            {
                db = new EFDatabase();
                return db.GetEstate(EstateID);
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public List<PriceHistory> GetPriceHistory(int? estateId)
        {
            try
            {
                db = new EFDatabase();
                return db.GetPriceHistory(estateId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ZipCode GetCityFromZipCode(int? zipCode)
        {
            try
            {
                db = new EFDatabase();
                return db.GetCityFromZipCode(zipCode);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
