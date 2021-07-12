using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_4
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            int x = (Program.x = 2) * 2;
            Console.WriteLine("static x = " + Program.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
