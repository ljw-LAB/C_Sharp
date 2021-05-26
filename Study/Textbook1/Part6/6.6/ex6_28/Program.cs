using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
            t.Join();
            Console.WriteLine("주 스레드 종료");
        }

        static void threadFunc()
        {
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(100*60);
            Console.WriteLine("스레드 종료!");
        }
    }
}
