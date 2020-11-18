using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    
    public interface IDatabase
    {
        public void CreateCustomer(Customer customer);

    }
}
