using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_4
{
    class Mathematics
    {
        public void PrintIfEven(int value)
        {
            if(value % 2 == 0)
            {
                Console.WriteLine(value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();

            int x = 5;
            m.PrintIfEven(x);
            x= 10;
            m.PrintIfEven(x);
            // int x = 5;
            // if(x % 2 == 0)
            // {
            //     Console.WriteLine(x);
            // }
            // x =10;
            // if(x % 2 == 0)
            // {
            //     Console.WriteLine(x);
            // }
        }
    }
}
