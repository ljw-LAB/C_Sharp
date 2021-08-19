using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_070
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Program x = new Program();
            //Console.WriteLine("가장 큰 수는 {0}", x.Larger(x.Larger(a, b), c));
            Console.WriteLine("가장 큰 수는 {0}", Larger(Larger(a, b), c));

        }

        // private int Larger(int a, int b)
        // {
        //     return (a >= b) ? a : b;
        // }
        private static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
