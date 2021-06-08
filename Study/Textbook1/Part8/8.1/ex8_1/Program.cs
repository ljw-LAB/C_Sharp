using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            var j = 6;

            Console.WriteLine(i.GetType().FullName);
            Console.WriteLine(j.GetType().FullName);
        }
    }
}
