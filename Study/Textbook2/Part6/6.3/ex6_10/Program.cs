using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex6_10
{
    class Program
    {
        static void ThreadBody()
        {
            Thread.Sleep(1000);
        }
        
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadBody));
            t.Start();
            Console.WriteLine("Current Priority : " + t.Priority);
            ++t.Priority;
            Console.WriteLine("Higher Priority : " + t.Priority);
        }
    }
}
