using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class SqlDatabase : IDatabase
    {
        private static SqlConnection conn;
        private static SqlConnection GetConnection()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            conn = new SqlConnection("Server=tcp:lacour.database.windows.net,1433;Initial Catalog=EstateBrokers;Persist Security Info=False;User ID=Jesper_laCour;Password=Azure1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return conn;
        }

        public void CreateCustomer(Customer customer)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com =
                new SqlCommand(
                    $"Insert into customer (name, address,phonenr,zipcode) values ('{customer.Name}','{customer.Address}',{customer.PhoneNr},{customer.ZipCode})",
                    conn);
            com.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateEstate(Estate estate)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand(
                $"Insert into Estate (Address, Type, BuildYear, RemodelYear, Condition, Areal, Rooms, Floors, Garden) values ('{estate.Address}','{estate.Type}',{estate.BuildYear},{estate.RemodelYear}, {estate.Condition}, {estate.Areal}, {estate.Rooms}, {estate.Floors}, {estate.Garden})",
                conn);
            com.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateCaseOrder(CaseOrder caseOrder)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com =
                new SqlCommand(
                    $"Insert into caseorder (CaseStatus, EstateID, SellerID, BrokerID) values ('{caseOrder.CaseStatus}',{caseOrder.EstateId},{caseOrder.SellerId},{caseOrder.BrokerId})",
                    conn);
            com.ExecuteNonQuery();
            conn.Close();
        }


        public Customer GetCustomer(int? customerId)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from Customer where CustomerID = {customerId}");
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();
            if (sqld.Read())
            {
                return new Customer(Convert.ToInt32(sqld[0]),
                    sqld[1].ToString(),
                    sqld[2].ToString(),
                    Convert.ToInt32(sqld[3]),
                    Convert.ToInt32(sqld[4]));
            }
            conn.Close();
            return null;
        }


        public List<Customer> GetAllCustomer(string name)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from Customer where name like '%{name}%'");
            List<Customer> allCustomers = new List<Customer>();
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();
            if (sqld.HasRows)
            {
                while (sqld.Read())
                {
                    allCustomers.Add(new Customer(
                        Convert.ToInt32(sqld["customerID"]),
                        sqld["name"].ToString(),
                        sqld["address"].ToString(),
                        Convert.ToInt32(sqld["phoneNr"]),
                        Convert.ToInt32(sqld["zipCode"])));
                }
            }

            conn.Close();
            return allCustomers;
        }

        public Estate GetEstate(int? estateID)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from Estate where EstateID = {estateID}");
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();
            if (sqld.Read())
            {
                return new Estate(Convert.ToInt32(sqld["estateId"]),
                    sqld["address"].ToString(),
                    Convert.ToInt32(sqld["buildYear"]),
                    Convert.ToInt32(sqld["remodelYear"]),
                    Convert.ToInt32(sqld["condition"]),
                    Convert.ToInt32(sqld["areal"]),
                    Convert.ToInt32(sqld["rooms"]),
                    Convert.ToInt32(sqld["floors"]),
                    Convert.ToBoolean(sqld["garden"]),
                    Convert.ToInt32(sqld["zipCode"]),
                    Convert.ToInt32(sqld["Housetype"]));

            }
            conn.Close();
            return null;
        }

        public List<Estate> GetAllEstates(string address)
        {

            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from Estate where address like '%{address}%'");
            List<Estate> allEstates = new List<Estate>();
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();
            if (sqld.HasRows)
            {
                while (sqld.Read())
                {

                    allEstates.Add(new Estate(Convert.ToInt32(sqld["estateId"]),
                        sqld["address"].ToString(),
                        Convert.ToInt32(sqld["buildYear"]),
                        Convert.ToInt32(sqld["remodelYear"]),
                        Convert.ToInt32(sqld["condition"]),
                        Convert.ToInt32(sqld["areal"]),
                        Convert.ToInt32(sqld["rooms"]),
                        Convert.ToInt32(sqld["floors"]),
                        Convert.ToBoolean(sqld["garden"]),
                        Convert.ToInt32(sqld["zipCode"]),
                        Convert.ToInt32(sqld["HouseType"])));
                }
            }
            conn.Close();
            return allEstates;
        }

        public CaseOrder GetCaseOrder(int caseOrderID)
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from caseorder where CaseOrderID = {caseOrderID}");
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();

            if (sqld.Read())
            {
                return new CaseOrder(Convert.ToInt32(sqld["caseID"]),
                    sqld["caseStatus"].ToString(),
                    Convert.ToInt32(sqld["customerId"]),
                    Convert.ToInt32(sqld["sellerId"]),
                    Convert.ToInt32(sqld["buyerId"]),
                    Convert.ToInt32(sqld["estateId"]));
            }
            conn.Close();
            return null;
        }

        public List<CaseOrder> GetAllCaseOrders()
        {
            var conn = GetConnection();
            conn.Open();
            SqlCommand com = new SqlCommand($"select * from caseorder");
            List<CaseOrder> allCaseOrders = new List<CaseOrder>();
            com.Connection = conn;
            SqlDataReader sqld = com.ExecuteReader();
            if (sqld.HasRows)
            {
                while (sqld.Read())
                {
                    allCaseOrders.Add(new CaseOrder(
                        Convert.ToInt32(sqld["caseID"]),
                        sqld["caseStatus"].ToString(),
                        Convert.ToInt32(sqld["customerId"]),
                        Convert.ToInt32(sqld["SellerId"]),
                        Convert.ToInt32(sqld["brokerId"]),
                        Convert.ToInt32(sqld["estateId"])));
                }


            }
            conn.Close();
            return allCaseOrders;
        }


        public EstateBrokersContext GetGridCustomerData(string name)
        {
            throw new NotImplementedException();
        }

        public EstateBrokersContext GetGridEstateData(string address)
        {
            throw new NotImplementedException();
        }


        public void InsertPrice(PriceHistory priceHistory)
        {
            throw new NotImplementedException();
        }

        public void SaveDBContext()
        {
            throw new NotImplementedException();
        }


        public List<PriceHistory> GetPriceHistory(int? estateId)
        {
            throw new NotImplementedException();
        }

        public ZipCode GetCityFromZipCode(int? zipCode)
        {
            throw new NotImplementedException();
        }

        public List<HouseType> GetHouseTypes()
        {
            throw new NotImplementedException();
        }

        public List<Estate> GetEstatesBasedOn_ZipCodeAndHousetype(int zipCode, int houseType, int remodelYear)
        {
            throw new NotImplementedException();
        }
    }
}
