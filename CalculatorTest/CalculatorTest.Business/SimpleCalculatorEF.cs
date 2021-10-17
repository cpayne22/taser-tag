using CalculatorTest.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Business
{
    public class SimpleCalculatorEF : ISimpleCalculator
    {
        ISimpleCalculator _baseCalculator;
        SimpleCalculatorContext _dbContext;
        public SimpleCalculatorEF(SimpleCalculatorContext dbContext)
        {
            _baseCalculator = new SimpleCalculatorConsole();
            _dbContext = dbContext;
        }
        public int Add(int start, int amount)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                var result = _baseCalculator.Add(start, amount);
                _dbContext.LogWrite(sw.ToString());
                return result;
            }
        }

        public int Divide(int start, int by)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int start, int by)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int start, int amount)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                var result = _baseCalculator.Subtract(start, amount);
                _dbContext.LogWrite(sw.ToString());
                return result;
            }
        }
    }
}
