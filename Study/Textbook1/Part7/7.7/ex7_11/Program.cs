using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex7_11
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Thread thread = new Thread(ThreadFunc);
        //     thread.Start();

        //     thread.Join();
        // }

        // private static void ThreadFunc(object obj)
        // {
        //     Console.WriteLine("ThreadFunc called!");
        // }

        //static void Main(string[] args)
        //{
        //    Thread thread = new Thread(
        //        delegate(object obj)
        //        {
        //            Console.WriteLine("ThreadFunc in anonymous method called!");
        //        }
        //    );
        //    thread.Start();
        //    thread.Join();
        //}

        delegate int? myDivide(int a, int b);

        static void Main(string[] args)
        {
            myDivide myFunc = delegate(int a, int b)
            {
                if( b == 0)
                {
                    return null;
                }

                return a/b;
            };
            Console.WriteLine("10 / 2 == " + myFunc(10, 2)); // 출력 결과 : 10 /2 ==5
            Console.WriteLine("10 / 0 == " + myFunc(10, 0)); // 출력 결과 : 10 /2 ==5

        }
    }
}
