using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_13
{
    class StaticConstructor
    {
        static int staticWithInitializer = 100;
        static int staticWithNoInitializer;
        static StaticConstructor()
        {
            staticWithNoInitializer = staticWithInitializer + 100;
        }

        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1 = {0}, field2 = {1}", staticWithInitializer, staticWithNoInitializer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstructor.PrintStaticVariable();
        }
    }
}
