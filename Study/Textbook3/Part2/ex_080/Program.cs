using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_080
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m!을 계산합니다. m를 입력하세요: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", m, Fact(m));
        }

        private static double Fact(double x)
        {
            if( x == 1)
            {
                return 1;
            }
            else
            {
                return x* Fact(x-1);
            }
        }
    }
}
