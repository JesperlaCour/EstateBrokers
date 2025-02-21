﻿using Model.Models;
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

        public List<HouseType> GetHouseTypes()
        {
            try
            {
                db = new EFDatabase();
                return db.GetHouseTypes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Estate> GetEstatesBasedOn_ZipCodeAndHousetype(int zipCode, int houseType, int remodelYear)
        {
            try
            {
                db = new EFDatabase();
                return db.GetEstatesBasedOn_ZipCodeAndHousetype(zipCode, houseType, remodelYear);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CaseOrder> GetAllCaseOrdrsForSearchByAddress(string address)
        {
            try
            {
                db = new EFDatabase();
                return db.GetAllCaseOrdrsForSearchByAddress(address);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Broker GetBroker(int brokerId)
        {
            try
            {
                db = new EFDatabase();
                return db.GetBroker(brokerId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department GetDepartment(int? departmentId)
        {
            try
            {
                db = new EFDatabase();
                return db.GetDepartment(departmentId);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<CaseStatus> GetCaseStatuses()
        {
            try
            {
                db = new EFDatabase();
                return db.GetCaseStatuses();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCaseOrderStatus(CaseOrder co)
        {
            try
            {
                db = new EFDatabase();
                db.UpdateCaseOrderStatus(co);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void CreateOpenHouse(OpenHouse openHouse)
        {
            try
            {
                EFDatabase ef = new EFDatabase();
                ef.CreateOpenHouse(openHouse);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DateTime?> GetDatesForOpenHouses()
        {
            db = new EFDatabase();
            return db.GetDatesForOpenHouses();

        }

        public List<OpenHouse> GetOpenHouses(DateTime date)
        {
            db = new EFDatabase();
            return db.GetOpenHouses(date);
        }

        public OpenHouse GetOpenHousesFromCaseOrderId(int caseOrderId)
        {
            db = new EFDatabase();
            return db.GetOpenHousesFromCaseOrderId(caseOrderId);
        }
    }
}
