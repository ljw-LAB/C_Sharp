using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 5;
            int a, b;
            ++x; --y;
            Console.WriteLine("x = " + x + ", y = " + y); // 4 4
            a = (++x) + 1;
            Console.WriteLine("x = " + x + ", a = " + a); // 5 6
            b = (y++) + 1;
            Console.WriteLine("y = " + y + ", b = " + b); // 5 5
        }
    }
}
