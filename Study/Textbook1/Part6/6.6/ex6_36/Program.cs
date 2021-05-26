using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ex6_36
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

            Hashtable ht1 = new Hashtable();
            ht1["data"] = data;
            ht1["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);
            ThreadPool.QueueUserWorkItem(threadFunc, ht1);

            Hashtable ht2 = new Hashtable();
            ht2["data"] = data;
            ht2["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);
            ThreadPool.QueueUserWorkItem(threadFunc, ht2);

            (ht1["evt"] as EventWaitHandle).WaitOne();
            (ht2["evt"] as EventWaitHandle).WaitOne();

            Console.WriteLine(data.Number);

        }

        static void threadFunc(object inst)
        {
            Hashtable ht = inst as Hashtable;
            
            MyData data = ht["data"] as MyData;

            for(int i = 0; i < 100000 ; i++)
            {
                data.Increment();
            }

            (ht["evt"] as EventWaitHandle).Set(); 
        }
    }
}
