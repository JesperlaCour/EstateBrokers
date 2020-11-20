
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;

namespace Controller
{
    public class CustomerControllerSingleton
    {
        private static CustomerControllerSingleton _instance;

        protected CustomerControllerSingleton()
        {
        }
        public static CustomerControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new CustomerControllerSingleton();
            }
            return _instance;
        }
        public void CreateCustomer(Customer customer)
        {
            IDatabase db = new DatabaseProxy();
            db.CreateCustomer(customer);
        }

        //Grid CustomerAdmin methods
        IDatabase db;
        public EstateBrokersContext GetGridCustomerData()
        {
            db = new DatabaseProxy();
            return db.GetGridCustomerData();
        }

        public void UpdateGridCustomerData()
        {
            db.UpdateGridCustomerData();
        }
    }
}
