using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Persistence
{
    public class SqlDatabase : IDatabase
    {
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
    }
}
