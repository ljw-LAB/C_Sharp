using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_8
{
    class Program
    {
        unsafe public static void Swap(int* px, int* py)
        {
            int tmp = *px;
            *px = *py;
            *py = tmp;
        }

        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before : x = " + x + ", y = " + y);
            unsafe
            {
                Swap(&x, &y);
            }
            Console.WriteLine("After : x = " + x + ", y = " + y);
        }
    }
}
