using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Business
{
    /*
     * 9.	Implement a dummy diagnostics interface that doesn’t report anything. 
     */

    public class SimpleCalculatorNoOutput : ISimpleCalculator
    {
        ISimpleCalculator _baseCalculator;
        public SimpleCalculatorNoOutput(ISimpleCalculator baseCalculator)
        {
            _baseCalculator = baseCalculator;
        }
        public int Add(int start, int amount)
        {
            return _baseCalculator.Add(start, amount);
        }

        public int Divide(int start, int by)
        {
            return _baseCalculator.Add(start, by);
        }

        public int Multiply(int start, int by)
        {
            return _baseCalculator.Add(start, by);
        }

        public int Subtract(int start, int amount)
        {
            return _baseCalculator.Add(start, amount);
        }
    }
}
