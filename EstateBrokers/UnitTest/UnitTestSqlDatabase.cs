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
    }
}
