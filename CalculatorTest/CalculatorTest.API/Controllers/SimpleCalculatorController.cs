using CalculatorTest.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorTest.API.Controllers
{
    [RoutePrefix("api/SimpleCalculator")]
    public class SimpleCalculatorController : ApiController
    {
        [HttpGet()]
        [Route("Addition")]
        public int AdditionGet(int start, int amount)
        {
            var calc = new SimpleCalculator();

            return (int)calc.Add(start, amount);
        }

        [HttpGet()]
        [Route("Subtract")]
        public int SubtractGet(int start, int amount)
        {
            var calc = new SimpleCalculator();

            return (int)calc.Subtract(start, amount);
        }

        [HttpGet()]
        [Route("Multiply")]
        public int MultiplyGet(int start, int by)
        {
            var calc = new SimpleCalculator();

            return (int)calc.Multiply(start, by);
        }

        [HttpGet()]
        [Route("Divide")]
        public int DivideGet(int start, int by)
        {
            var calc = new SimpleCalculator();

            return (int)calc.Divide(start, by);
        }
    }
}
