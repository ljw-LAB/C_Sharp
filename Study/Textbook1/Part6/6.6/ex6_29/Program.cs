using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.Start(10);
        }

        static void threadFunc(object initalValue)
        {
            int intValue = (int)initalValue;
            Console.WriteLine(intValue);
        }
    }
}
