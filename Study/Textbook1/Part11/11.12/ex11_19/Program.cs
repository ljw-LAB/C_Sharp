using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_19
{
    class Program
    {
        // static void WriteLine(uint? arg)
        // {
        //     Console.WriteLine("uint? == " + arg);
        // }

        // static void WriteLine(int? arg)
        // {
        //     Console.WriteLine("int? == " + arg);
        // }

        static void WriteLine(uint arg)
        {
            Console.WriteLine("uint == " + arg);
        }

        static void WriteLine(int arg)
        {
            Console.WriteLine("int == " + arg);
        }

        static void Main(string[] args)
        {
            //WriteLine(null);
            WriteLine(5);
        }
    }
}
