using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            short c = 32767;
            
            unchecked
            //checked
            {
                c++;
            }
            //c++;
            Console.WriteLine(c);

            int n = 32768;
            c = (short)n;
            Console.WriteLine(c);

            short c1 = -32768;
            c1--;
            Console.WriteLine(c1);

            int n1 = -32769;
            c1 = (short)n1;
            Console.WriteLine(c1);
        }
    }
}
