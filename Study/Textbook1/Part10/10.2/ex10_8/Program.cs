using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex10_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int result3 = Method3();
            int result5 = Method5();
            Console.WriteLine(result3 + result5);
        }

        private static int Method3()
        {
            Thread.Sleep(3000);
            return 3;
        }

        private static int Method5()
        {
            Thread.Sleep(5000);
            return 5;
        }
    }
}
