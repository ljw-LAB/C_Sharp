using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency:........{0:C}\n" +
                "(D) Currency:........{0:D}\n" +
                "(E) Currency:........{1:E}\n" +
                "(F) Currency:........{1:F}\n" +
                "(G) Currency:........{0:G}\n" +
                "(N) Currency:........{0:N}\n" +
                "(P) Currency:........{1:P}\n" +
                "(R) Currency:........{1:R}\n" +
                "(X) Currency:........{0:X}\n", -12345678, -1234.5678f

            );
        }
    }
}
