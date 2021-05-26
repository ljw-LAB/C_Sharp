using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_35
{
    class Program
    {
        static void Main(string[] args)
        {
            EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start(ewh);

            ewh.WaitOne();
            Console.WriteLine("주  스레드 종료!");
        }
        static void threadFunc(object state)
        {
            EventWaitHandle ewh = state as EventWaitHandle;

            Console.WriteLine("60초후에 프로그램 종료");
            Thread.Sleep(100*60);
            Console.WriteLine("쓰레드 종료!");
            ewh.Set();
        }
    } 
}
