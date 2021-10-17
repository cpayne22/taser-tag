using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace CalculatorTest.Business
{
    public class SimpleCalculatorConsole: ISimpleCalculator
    {
        ConsoleTraceListener consoleTracer;
        ISimpleCalculator _baseCalculator;

        public SimpleCalculatorConsole()
        {
            SetupTrace();
            _baseCalculator = new SimpleCalculator();

        }

        public SimpleCalculatorConsole(ISimpleCalculator  baseCalculator)
        {
            SetupTrace();
            _baseCalculator = baseCalculator;
        }

        private void SetupTrace()
        {
            consoleTracer = new ConsoleTraceListener(false);
            Trace.Listeners.Add(consoleTracer);
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting SimpleCalculatorConsole");

        }
        public int Add(int start, int amount)
        {
            Trace.WriteLine($"Addition - {start}, {amount}");
            var result = _baseCalculator.Add(start, amount);
            Trace.WriteLine($"Result is {result}");
            return result;
        }

        public int Divide(int start, int by)
        {
            Trace.WriteLine($"Divide - {start}, {by}");
            var result = _baseCalculator.Divide(start, by);
            Trace.WriteLine($"Result is {result}");
            return result;
        }

        public int Multiply(int start, int by)
        {
            Trace.WriteLine($"Multiply - {start}, {by}");
            var result = _baseCalculator.Multiply(start, by);
            Trace.WriteLine($"Result is {result}");
            return result;
        }

        public int Subtract(int start, int amount)
        {
            Trace.WriteLine($"Multiply - {start}, {amount}");
            var result = _baseCalculator.Subtract(start, amount);
            Trace.WriteLine($"Result is {result}");
            return result;
        }
    }
}
