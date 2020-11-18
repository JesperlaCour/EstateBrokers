using BusinessLogicLayer;
using Model.Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
