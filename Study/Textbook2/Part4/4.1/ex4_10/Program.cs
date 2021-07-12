using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_10
{
    class Program
    {
        void SomeThing()
        {
            Console.WriteLine("SomeThing() is called.");
        }

        void SomeThing(int i)
        {
            Console.WriteLine("SomeThing(int) is called.");
        }

        void SomeThing(int i, int j)
        {
            Console.WriteLine("SomeThing(int, int) is called.");
        }

        void SomeThing(double d)
        {
            Console.WriteLine("SomeThing(double) is called.");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);

        }
    }
}
