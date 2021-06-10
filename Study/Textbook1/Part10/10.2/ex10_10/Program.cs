using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var task3 = Method3Async();
            var task5 = Method5Async();

            Task.WaitAll(task3, task5);
            Console.WriteLine(task3.Result + task5.Result);
        }

        private static Task<int> Method3Async()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                return 3;
            });
        }

        private static Task<int> Method5Async()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                return 5;
            });
        }
    }
}
