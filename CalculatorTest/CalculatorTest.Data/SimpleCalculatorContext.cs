using CalculatorTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Data
{
    public class SimpleCalculatorContext : DbContext
    {
        public SimpleCalculatorContext()
        {
        }
        public SimpleCalculatorContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Log> Log { get; set; }

        public void LogWrite(string output)
        {
            var l = new Log();
            l.CreatedUTC = DateTime.UtcNow;
            l.Output = output;
            Log.Add(l);
            SaveChanges();
        }
    }
}
