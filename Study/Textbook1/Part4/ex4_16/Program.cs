using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string txt = "text";

            Type intType = n.GetType();

            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType().FullName);

            Type type = typeof(double);
            Console.WriteLine(type.FullName);
            Console.WriteLine(typeof(System.Int16).FullName);
        }
    }
}
