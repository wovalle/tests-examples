using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Project.Library;

namespace Test.Project.Tests
{
    [TestClass]
    public class Numbers_Test
    {
        private static Numbers Numbers = new Numbers();

        [TestMethod]
        public void Sum_Test()
        {
            var sum = Numbers.Sum(2,2);
            Assert.AreEqual(sum, 4);
        }

        [TestMethod]
        public void Substract_Test()
        {
            var sum = Numbers.Substract(2, 2);
            Assert.AreEqual(sum, 0);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            var sum = Numbers.Multiply(2, 2);
            Assert.AreEqual(sum, 4);
        }

        [TestMethod]
        public void Divide_Test()
        {
            var sum = Numbers.Divide(2, 2);
            Assert.AreEqual(sum, 1);
        }
    }
}
