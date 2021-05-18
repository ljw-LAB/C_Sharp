using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // Stopwatch 기능을 사용하려면 반드시 추가 해야함

namespace ex6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            Sum();
            st.Stop();

            Console.WriteLine("Total Ticks : " + st.ElapsedTicks);
            Console.WriteLine("Millisecond : " + st.ElapsedMilliseconds);
            Console.WriteLine("Second : " + st.ElapsedMilliseconds/1000);
            Console.WriteLine("Second : " + st.ElapsedTicks/Stopwatch.Frequency);
            
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
