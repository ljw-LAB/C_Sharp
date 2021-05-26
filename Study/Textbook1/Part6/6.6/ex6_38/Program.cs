using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_38
{
    public class Calc
    {
        public static long Cumsum(int start, int end)
        {
            long sum = 0;

            for(int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
    class Program
    {
        public delegate long CalcMethod(int start, int end);
        static void Main(string[] args)
        {
            CalcMethod calc = new CalcMethod(Calc.Cumsum);
            long result = calc(1, 100);
            Console.WriteLine(result);
        }
    }
}
