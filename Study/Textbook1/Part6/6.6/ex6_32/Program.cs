using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_32
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Thread t = new Thread(threadFunc);
                t.Start(i);
            }
        }

        static void threadFunc(object value)
        {
            Console.WriteLine(value + "번째 스레드");
        }
    }
}
