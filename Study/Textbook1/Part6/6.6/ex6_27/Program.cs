using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_27
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
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000*60);
            Console.WriteLine("스레드 종료! ");
        }
    }
}
