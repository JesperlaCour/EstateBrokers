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
            return dbcontext.CaseOrders.Where(co => co.CaseOrderID == caseOrderID).FirstOrDefault();
        }

        public Customer GetCustomer(int customerID)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Customers.Where(c => c.CustomerId == customerID).FirstOrDefault();
        }

        public Estate GetEstate(int EstateID)
        {
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            return dbcontext.Estates.Where(e => e.EstateId == EstateID).FirstOrDefault();
        }


        //GridView
        EstateBrokersContext context;
        public EstateBrokersContext GetGridCustomerData()
        {
            context = new EstateBrokersContext();
            context.Customers.Load();
            return context;
        }
        public void UpdateGridCustomerData()
        {
            context.SaveChanges();
        }
    }
}
