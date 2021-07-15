using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex6_9
{
    class ThreadJoin
    {
        public int start;
        public int perfectNumber;
        public void ThreadBody()
        {
            int sum;
            for(int i = start; ; i++)
            {
                sum = 0;
                for(int j = 1; j <= i/2; j++)
                    if(i % j == 0) sum += j;
                if(i == sum)
                {
                    perfectNumber = i;
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadJoin obj = new ThreadJoin();
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t = new Thread(ts);
            Console.Write("Enter a number : ");
            obj.start = int.Parse(Console.ReadLine());
            t.Start();
            t.Join();
            Console.WriteLine("The perfect number over {0} is {1}.", obj.start, obj.perfectNumber);
        }
    }
}
