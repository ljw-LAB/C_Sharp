using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 250;
            short s = b;
            Console.WriteLine(s);

            ushort u = 65;
            char c = (char)u;
            Console.WriteLine(c);

            int n = 40000;
            short s1 = (short)n;
            Console.WriteLine(s1);
        }
    }
}
