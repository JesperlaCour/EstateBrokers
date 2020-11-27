using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Persistence;
using Model.Models;

namespace UnitTest
{
    [TestClass]
    public class UnitTestDataEF
    {
        [TestMethod]
        public void GetCustomerExpectOneInstance()
        {
            
            //arrange
            IDatabase testDB = new EFDatabase();

            //Act
            string actual = testDB.GetCustomer(1).Name;
            string expected = "Marc";
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetAllCustomersExpect5Instances()
        {
            //arrange
            IDatabase testDB = new EFDatabase();

            //Act
            int actual = testDB.GetAllCustomer("").Count();
            int expected = 5;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEstatesToListingCalculation()
        {
            //arrange
            IDatabase testDB = new EFDatabase();

            //Act
            int actual = testDB.GetEstatesBasedOn_ZipCodeAndHousetype(7100, new HouseType(1).TypeId, 2000).Count();
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
