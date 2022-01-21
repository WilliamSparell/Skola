using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDÖvning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDÖvning.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var add = new Calculator();
            var expected = 15;

            var result = add.Add(10, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var multiply = new Calculator();
            var expected = 50;

            var result = multiply.Multiply(10, 5);

            Assert.AreEqual((double)expected, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var divide = new Calculator();
            var expected = 4;

            var result = divide.Divide(9, 2);
                        
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var subtract = new Calculator();
            var expected = 5;

            var result = subtract.Subtract(10, 5);

            Assert.AreEqual(expected, result);
        }
    }
}