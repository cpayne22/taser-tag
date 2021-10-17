using CalculatorTest.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CalculatorTest.UnitTests
{
    [TestClass]
    public class SimpleCalculatorConsoleTests
    {
        StringWriter sw;
        [TestInitialize]
        public void TestInitialize()
        {
            sw = new StringWriter();
            Console.SetOut(sw);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (sw != null)
            {
                sw.Dispose();
            }
        }

        [TestMethod]
        public void Addition()
        {
            var calc = new SimpleCalculatorConsole();
            var result = calc.Add(2, 3);
            string expected = "Starting SimpleCalculatorConsole\r\nAddition - 2, 3\r\nResult is 5\r\n";
            Assert.AreEqual(expected, sw.ToString());            
        }

        [TestMethod]
        public void Subtract()
        {
            var calc = new SimpleCalculatorConsole();

            var result = calc.Subtract(2, 3);
            string expected = "Starting SimpleCalculatorConsole\r\nMultiply - 2, 3\r\nResult is -1\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void Multiply()
        {
            var calc = new SimpleCalculatorConsole();
            var result = calc.Multiply(2, 3);
            string expected = "Starting SimpleCalculatorConsole\r\nMultiply - 2, 3\r\nResult is 6\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void Divide()
        {
            var calc = new SimpleCalculatorConsole();
            var result = calc.Divide(6, 3);
            string expected = "Starting SimpleCalculatorConsole\r\nDivide - 6, 3\r\nResult is 2\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}
