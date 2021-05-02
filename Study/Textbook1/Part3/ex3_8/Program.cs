using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            Console.WriteLine(text);

            string text1 = "Hello"; text1 = text1 + "world";
            Console.WriteLine(text1);

            int n = 5;
            int divider = 3;
            int mod = n % divider;
            Console.WriteLine(mod);

            int n1 = 500;
            Console.WriteLine("n =" + n1);
        }
    }
}
