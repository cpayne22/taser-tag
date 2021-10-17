using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Business
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            var calc = new SimpleCalculator();
            Console.WriteLine(calc.Add(4, 2));

            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            await Program.useAPI();
            
        }

        /*
 * 14.	Modify the console application to access the calculator web service to perform its calculations instead of using an internal class. 
 */
        static async Task useAPI()
        {
            var requestContent = new StringContent("", Encoding.UTF8, "application/json");

            var response = await client.GetAsync("https://localhost:44303/api/SimpleCalculator/addition?start=4&amount=3");

            var responseString =await  response.Content.ReadAsStringAsync();
            // Assert.AreEqual("7", responseString);
        }


    }
}
