using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Data.Models
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        public DateTime CreatedUTC { get; set; }
        public string Output { get; set; }
    }
}
