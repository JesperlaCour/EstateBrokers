using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;

namespace UnitTest
{
    [TestClass]
    public class UnitTestSqlDatabase
    {
        [TestMethod]
        public void GetCustomerByCustomerId()
        {
            IDatabase testDb = new SqlDatabase();

            string actual = testDb.GetCustomer(1).Name;
            string expected = "Marc";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEstateByEstateId()
        {
            IDatabase testDb = new SqlDatabase();

            string actual = testDb.GetEstate(1).Type;
            string expected = "Villa";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAllEstates()
        {
            //arrange
            IDatabase testDB = new SqlDatabase();

            //Act
            int actual = testDB.GetAllEstates("").Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetAllCustomers()
        {
            //arrange
            IDatabase testDB = new SqlDatabase();

            //Act
            int actual = testDB.GetAllCustomer("").Count;
            int expected = 6;

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}