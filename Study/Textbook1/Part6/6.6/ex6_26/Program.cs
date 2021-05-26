using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.Start();
        }

        static void threadFunc()
        {
            Console.WriteLine("thread run!");
        }
    }
}