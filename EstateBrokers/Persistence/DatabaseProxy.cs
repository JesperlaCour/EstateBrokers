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
            throw new NotImplementedException();
        }
        public void CreateCaseOrder(CaseOrder caseOrder)
        {
            throw new NotImplementedException();
        }


        public List<CaseOrder> GetAllCaseOrders()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer(string name)
        {
            throw new NotImplementedException();
        }

        public List<Estate> GetAllEstates(string address)
        {
            throw new NotImplementedException();
        }

        public CaseOrder GetCaseOrder(int CaseOrderID)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int customerID)
        {
            throw new NotImplementedException();
        }

        public Estate GetEstate(int EstateID)
        {
            throw new NotImplementedException();
        }
    }
}
