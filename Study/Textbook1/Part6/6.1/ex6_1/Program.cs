using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime now = DateTime.Now;
            // Console.WriteLine(now);

            // DateTime dayForChildren = new DateTime(now.Year, 5, 5);
            // Console.WriteLine(dayForChildren);

            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;

            long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Total Ticks:" + gap);
            Console.WriteLine("Milliseond : " + (gap / 10000));
            Console.WriteLine("Second " + (gap / 10000 / 1000));
        }

        private static long Sum()
        {
            long sum = 0;
            for(int i = 0 ; i <1000000; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
