using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace CalculatorTest.Business
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Divide(int start, int by)
        {
            return start / by;
        }

        public int Multiply(int start, int by)
        {
            return start * by;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
