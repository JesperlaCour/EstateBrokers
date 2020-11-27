using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
    //Author Jesper
    public class EFDatabase : IDatabase
    {
        public void CreateCaseOrder(CaseOrder caseOrder)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            dbcontext.CaseOrders.Add(caseOrder);
            dbcontext.SaveChanges();
        }

        public void CreateCustomer(Customer customer)
        {
            //throw new Exception();
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            dbcontext.Customers.Add(customer);
            dbcontext.SaveChanges();
        }

        public void CreateEstate(Estate estate)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            dbcontext.Estates.Add(estate);
            dbcontext.SaveChanges();
        }

        public List<CaseOrder> GetAllCaseOrders()
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.CaseOrders.ToList();
        }

        

        public List<Customer> GetAllCustomer(string name)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Customers.Where(c => c.Name == $"%{name}%").ToList();
        }

        public List<Estate> GetAllEstates(string address)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Estates.Where(e => e.Address == $"%{address}%").ToList();
        }

        public CaseOrder GetCaseOrder(int caseOrderID)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.CaseOrders.Where(co => co.CaseOrderId == caseOrderID).FirstOrDefault();
        }

        public Customer GetCustomer(int? customerID)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Customers.Where(c => c.CustomerId == customerID).FirstOrDefault();
        }

        public Estate GetEstate(int? EstateID)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Estates.Where(e => e.EstateId == EstateID).FirstOrDefault();
        }


        //GridViewCustomer
        EstateBrokersContext context;
        public EstateBrokersContext GetGridCustomerData(string name)
        {
            context = new EstateBrokersContext();
            context.Customers.Where(c => c.Name.Contains(name)).Load();
            return context;
        }
        

        //GridViewEstate
        public EstateBrokersContext GetGridEstateData(string address)
        {
            context = new EstateBrokersContext();
            context.Estates.Where(e => e.Address.Contains(address)).Load();
            return context;
        }
        
        public void InsertPrice(PriceHistory priceHistory)
        {
            context = new EstateBrokersContext();
            context.PriceHistories.Add(priceHistory);
            context.SaveChanges();
        }
        //Broker
        public DbSet<Broker> GetBrokers()
        {
            context = new EstateBrokersContext();
            context.Brokers.Load();
            return context.Brokers;
        }
        public DbSet<HouseType> GetTypes()
        {
            context = new EstateBrokersContext();
            context.HouseTypes.Load();
            return context.HouseTypes;
        }
        public void SaveDBContext()
        {
            context.SaveChanges();
        }

        public List<PriceHistory> GetPriceHistory(int? estateId)
        {
            context = new EstateBrokersContext();
            return context.PriceHistories.Where(e => e.EstateId == estateId).ToList();
        }

        public ZipCode GetCityFromZipCode(int? zipCode)
        {
            context = new EstateBrokersContext();
            return context.ZipCodes.Where(z => z.ZipCode1 == zipCode).FirstOrDefault();
        }

        public List<HouseType> GetHouseTypes()
        {
            context = new EstateBrokersContext();
            return context.HouseTypes.ToList();
        }

        public List<Estate> GetEstatesBasedOn_ZipCodeAndHousetype(int zipCode, int houseType, int remodelYear)
        {
            context = new EstateBrokersContext();
            return context.Estates.Where(
                z => z.ZipCode == zipCode
                && z.TypeId == houseType
                && (z.RemodelYear > remodelYear - 6 && z.RemodelYear < remodelYear + 6)).ToList();
        }

        public List<CaseOrder> GetAllCaseOrdrsForSearchByAddress(string address)
        {
            context = new EstateBrokersContext();
            
            return context.CaseOrders.Include(s => s.Estate).Where(s => s.Estate.Address.Contains(address)).ToList();
            
        }

        public Broker GetBroker(int caseOrderId)
        {
            context = new EstateBrokersContext();
            return context.Brokers.Where(b => b.BrokerId == caseOrderId).FirstOrDefault();
        }

        public Department GetDeparment(int? departmentId)
        {
            context = new EstateBrokersContext();
            return context.Departments.Where(d => d.DepartmentId == departmentId).FirstOrDefault();
        }

        public List<CaseStatus> GetCaseStatuses()
        {
            context = new EstateBrokersContext();
            return context.CaseStatuses.ToList();
        }

        public void UpdateCaseOrderStatus(CaseOrder co)
        {
            context = new EstateBrokersContext();
            context.Update(co);
            //context.Add(co);
            context.SaveChanges();
        }
    }
}
