using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;


namespace CollegeConsoleLibTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void Address_Init_CreatesAddress()
        {
            // Arrange
            Address address;
            string street = "941 Progress Ave";
            string city = "Scarborough";
            string state = "ON";
            // Act
            address = new Address(street, city, state);
            // Assert
            bool valuesAssigned = true;
            valuesAssigned &= (address.Street == street);
            valuesAssigned &= (address.City == city);
            valuesAssigned &= (address.State == state);
            Assert.IsTrue(valuesAssigned);
        }
    }
}
