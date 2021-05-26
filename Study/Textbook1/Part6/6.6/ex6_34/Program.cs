using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_34
{
    class MyData
    {
        int number = 0;

        public int Number{ get{return number;} }

        public void Increment()
        {
            number++;
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            MyData data = new MyData();
            ThreadPool.QueueUserWorkItem(threadFunc, data);
            ThreadPool.QueueUserWorkItem(threadFunc, data);

            Thread.Sleep(1000);
            Console.WriteLine(data.Number);
        }

        static void threadFunc(object inst)
        {
            MyData pg = inst as MyData;
            
            for(int i = 0; i < 100000 ; i++)
            {
                pg.Increment();
            }
        }

    }
}
