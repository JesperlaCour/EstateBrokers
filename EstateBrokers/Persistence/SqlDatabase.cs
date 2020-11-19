using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace Persistence
{
    public class SqlDatabase : IDatabase
    {
        public void CreateCaseOrder(CaseOrder caseOrder)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            
            SqlCommand com = new SqlCommand($"Insert into customer (name, address,phonenr,zipcode) values ('{customer.Name}','{customer.Address}',{customer.PhoneNr},{customer.ZipCode})",conn);
            //com.Connection = conn;
            com.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateEstate(Estate estate)
        {
            throw new NotImplementedException();
        }

        public List<CaseOrder> GetAllCaseOrders()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAllCustomer(string name)
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
