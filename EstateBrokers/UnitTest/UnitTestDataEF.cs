using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Controller;
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

        [TestMethod]
        public void GetOpenHousesByDate()
        {
            //Arrange
            IDatabase testDB = new EFDatabase();
            DateTime expectedDay = new DateTime(2020, 12, 17);

            //Act
            var actual = testDB.GetOpenHouses(expectedDay).Count();
            var expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSoldHousesByZipCodeAndDates()
        {

            //Arrange 
            SalesStatisticControllerSingleton
            testScs = SalesStatisticControllerSingleton.Instance();
            DateTime expectedDateFrom = new DateTime(2020, 11, 12);
            DateTime expectedDateTo = new DateTime(2020, 12, 7);



            //Act
            var actual = testScs.GetSoldHouses(7100, expectedDateFrom, expectedDateTo).Count();
            var expected = 4;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
