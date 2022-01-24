using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlow_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calc = new Calculator();
            calc.FirstNumber = 10;
            calc.SecondNumber = 12;
            var expected = 22;

            var actual = calc.Add();

            Assert.AreEqual(expected, actual);
        }
    }
}