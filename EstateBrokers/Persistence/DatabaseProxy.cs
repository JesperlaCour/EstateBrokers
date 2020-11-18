using Model.Models;
using System;
using System.Collections.Generic;
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
    }
}
