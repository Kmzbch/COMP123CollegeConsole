using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Person_RegNumber_Gets()
        {
            // Arrange
            int notExpected = 0;
            Person person = new Person("John", new DateTime(1999, 9, 9));
            // Act
            int actual = person.RegNumber;
            // Assert
            Assert.AreNotEqual(notExpected, actual);
        }
        [TestMethod]
        public void Person_Name_GetsAndSets()
        {
            // Arrange
            string expected = "Bob";
            Person person = new Person("John", new DateTime(1999, 9, 9));
            // Act
            person.Name = "Bob";
            // Assert
            string actual = person.Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Person_DOB_GetsAndSets()
        {
            // Arrange
            DateTime expected = new DateTime(2000, 1, 1);
            Person person = new Person("John", new DateTime(1999, 9, 9));
            // Act
            person.DOB = new DateTime(2000, 1, 1);
            // Assert
            DateTime actual = person.DOB;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Person_Address_GetsAndSets()
        {
            // Arrange
            Address expected = new Address("941 Progress Ave", "Scarborough", "ON");
            Person person = new Person("John", new DateTime(1999, 9, 9));
            // Act
            person.Address = new Address("941 Progress Ave", "Scarborough", "ON");
            // Assert
            Address actual = person.Address;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Person_TelephoneNumber_GetsAndSets()
        {
            // Arrange
            ulong expected = 1111111111;
            Person person = new Person("John", new DateTime(1999, 9, 9));
            // Act
            person.TelephoneNumber = 1111111111;
            // Assert
            ulong actual = person.TelephoneNumber;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Person_Init_WithParameters_CreatesPerson()
        {
            // Arrange
            Person p = null;
            string name = "John";
            DateTime dob = new DateTime(1999, 9, 9);
            Address address = new Address("941 Progress Ave", "Scarborough", "ON");
            ulong telephoneNumber = 9999999999;
            // Act
            p = new Person()
            {
                Name = name,
                DOB = dob,
                Address = address,
                TelephoneNumber = telephoneNumber
            };
            // Assert
            bool valuesAssigned = true;
            valuesAssigned &= (p.RegNumber != 0);
            valuesAssigned &= (p.Name == name);
            valuesAssigned &= (p.DOB == dob);
            valuesAssigned &= (p.Address.Equals(address));
            valuesAssigned &= (p.TelephoneNumber == telephoneNumber);
            Assert.IsTrue(valuesAssigned);
        }

        [TestMethod]
        public void Person_Init_AssignsUniqueRegNumber()
        {
            // Arrange
            Person p1 = new Person("John", new DateTime(1999, 9, 9));
            // Act
            Person p2 = new Person("Bob", new DateTime(2000, 1, 1));
            // Assert
            Assert.AreNotEqual(p1.RegNumber, p2.RegNumber);
        }

    }
}
