﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex6_33_4
{
    class MyData
    {
        int number = 0;
        public int Number{ get{return number;} }

        public void Increment()
        {
            Interlocked.Increment(ref number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();

            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);

            t1.Start(data);
            t2.Start(data);

            t1.Join();
            t2.Join();

            Console.WriteLine(data.Number);
        }

        static void threadFunc(object inst)
        {
            MyData data = inst as MyData;
            for(int i = 0; i < 100000; i++)
            {
                data.Increment();
            }
        }
    }
}
