using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class EFDatabase : IDatabase
    {
        public void CreateCustomer(Customer customer)
        {
            throw new Exception();
            EstateBrokersContext dbcontext = new EstateBrokersContext();
            dbcontext.Customers.Add(customer);
            dbcontext.SaveChanges();
        }
    }
}
