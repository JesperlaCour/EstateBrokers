using Model.Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class CustomerCRUD
    {
        public void CreateCustomer(Customer customer)
        {
            IDatabase db = new DatabaseProxy();
            db.CreateCustomer(customer);
        }
    }
}
