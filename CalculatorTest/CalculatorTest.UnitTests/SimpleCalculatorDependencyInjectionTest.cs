using CalculatorTest.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.UnitTests
{
    [TestClass]
    public class SimpleCalculatorDependencyInjectionTest
    {
        /*
         * 8.	Implement the diagnostics interface and inject it into the calculator at runtime.
         */

        [TestMethod]
        public void AdditionWithInjectingTheSimpleCalculator()
        {
            var calc = new SimpleCalculator();
            var calcConsole = new SimpleCalculatorConsole(calc);
            var result = calcConsole.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        /*
         * 9.	Implement a dummy diagnostics interface that doesn’t report anything. 
         */

        [TestMethod]
        public void AdditionWithADummyInjectorDoingNothing()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var calc = new SimpleCalculator();
                var calcNoOutput = new SimpleCalculatorNoOutput(calc);
                var result = calcNoOutput.Add(2, 3);
                Assert.AreEqual(5, result);
                Assert.AreEqual("", sw.ToString());
            }
        }

    }
}
