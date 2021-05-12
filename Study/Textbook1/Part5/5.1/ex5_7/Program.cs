using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_7
{
    class Program
    {
        unsafe static void GetAddResult(int* p, int a, int b)
        {
            *p = a+b;
        }
        static void Main(string[] args)
        {
            int i;
            unsafe
            {
                GetAddResult(&i, 5, 10);
            }
            Console.WriteLine(i);
        }
    }
}
