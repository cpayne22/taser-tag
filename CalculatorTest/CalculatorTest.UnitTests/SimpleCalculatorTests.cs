using CalculatorTest.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest.UnitTests
{
    [TestClass]
    public class SimpleCalculatorTests
    {
        [TestMethod]
        public void Addition()
        {
            var calc = new SimpleCalculator();
            var result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract()
        {
            var calc = new SimpleCalculator();
            var result = calc.Subtract(2, 3);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Multiply()
        {
            var calc = new SimpleCalculator();
            var result = calc.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Divide()
        {
            var calc = new SimpleCalculator();
            var result = calc.Divide(6, 3);
            Assert.AreEqual(2, result);
        }
    }
}
