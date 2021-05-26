using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 동기화 방법
// 1. 클래스에서 동기화 
// 2. 함수에서 동기화
namespace ex6_33_3
{
    class MyData
    {
        // 클래스에서 스레드 동기화
        int number = 0;
        public object _numberlock = new object();
        public int Number{ get{return number;} }

        public void Increment()
        {
            lock(_numberlock)
            {
                number++;
            }
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
                // 함수에서 스레드 동기화
                lock(data)
                {
                    data.Increment();
                }
            }
        }
    }
}
