using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                (obj) =>
                {
                    Console.WriteLine("process workitem");
                }, null);

            Task task1 = new Task(
                () =>
                {
                    Console.WriteLine("process workitem");
                });

            task1.Start();

            Task task2 = new Task(
                (obj) =>
                {
                    Console.WriteLine("process taskitem(obj)");
                },null);

            task2.Start();
            Console.ReadLine();
        }
    }
}
