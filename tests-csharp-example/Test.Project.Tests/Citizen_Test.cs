using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Project.Library;


namespace Test.Project.Tests
{
    [TestClass]
    public class Citizen_Test
    {
        /*Data*/
        Citizen Willy = new Citizen()
        {
            Name = "Willy",
            LastName = "Ovalle",
            Document_Number = "00100101010",
            BirthDate = new DateTime(1990, 01, 01),
            Sex = 'M'
        };


        [TestMethod]
        public void Citizen_Creation()
        {

            Assert.IsTrue(Willy.Id == Guid.Empty);
            Assert.IsTrue(Willy.Save());
            Assert.AreEqual(Willy.Name, "Willy");
            Assert.AreEqual(Willy.LastName, "Ovalle");
            Assert.AreEqual(Willy.Sex, (char)Citizen.SexType.Male);
            Assert.AreEqual(Willy.BirthDate, new DateTime(1990, 01, 01));
            Assert.AreEqual(Willy.Document_Number, "00100101010");
            Assert.IsTrue(Willy.Id != Guid.Empty);
        }

        [TestMethod]
        public void Citizen_Age()
        {
            Assert.IsTrue(Willy.Age() >= 23);
        }

        [TestMethod]
        public void Citizen_Adult()
        {
            Assert.IsTrue(Willy.IsAdult());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Citizen_Should_Throw_Invalid_Sex()
        {
            Willy.Sex = 'Y';
        }

        [TestMethod, ExpectedException(typeof(Exception), "Invalid blank document number")]
        public void Citizen_Should_Throw_Invalid_Document_Number()
        {
            Willy.Document_Number = "This is my document Number";
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Citizen_Should_Throw_Incomplete_Document_Number()
        {
            Willy.Document_Number = "1234567891";
        }

    }
}
