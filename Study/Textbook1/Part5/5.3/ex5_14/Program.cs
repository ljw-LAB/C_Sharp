using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 0;

            try
            {
                int quotient = 10 / divisor;
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("-------------------");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
