using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length <2)
            {
                return;
            }
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
        }
    }
}
