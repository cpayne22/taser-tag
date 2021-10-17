using CalculatorTest.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Business
{
    public class SimpleCalculatorADO : ISimpleCalculator
    {
        ISimpleCalculator _baseCalculator;
        string _cn;

        /* 
         * 12.	Implement another class that does not use EF and instead uses a stored procedure and ADO.NET to write the diagnostics data.
         */
        public SimpleCalculatorADO(string cn)
        {
            _baseCalculator = new SimpleCalculatorConsole();
            _cn = cn;
        }


        public int Add(int start, int amount)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                var result = _baseCalculator.Add(start, amount);

                using (SqlConnection con = new SqlConnection(_cn))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Addition", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Start", SqlDbType.Int).Value = start;
                        cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = amount;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

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
            throw new NotImplementedException();
        }
    }
}
