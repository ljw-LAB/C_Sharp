using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000000;
            Console.WriteLine(i*i); //오버플로우
            long l = i;
            Console.WriteLine(l*l);
        }
    }
}
