using BusinessLogicLayer;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;

namespace Controller
{
    public class ControllerSingleton
    {
        private static ControllerSingleton _instance;

      

        protected ControllerSingleton()
        {
            
        }
        public static ControllerSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new ControllerSingleton();
            }
            return _instance;
        }
        public void CreateCustomer(Customer customer)
        {
            CustomerCRUD customer1 = new CustomerCRUD();
            customer1.CreateCustomer(customer);
        }

        EFDatabase efDB;
        public EstateBrokersContext GetGridCustomerData()
        {
            efDB = new EFDatabase();
            return efDB.GetGridCustomerData();
        }

        public void UpdateGridCustomerData()
        {
            efDB.UpdateGridCustomerData();
        }
    }
}
