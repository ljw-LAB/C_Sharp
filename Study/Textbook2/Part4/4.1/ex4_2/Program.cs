using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2
{
    class Program
    {
        int instanceVariable;
        static int staticVariable;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.instanceVariable =10;
            Program.staticVariable = 20;
            Console.WriteLine("instance variable = {0}, static variable = {1}", obj.instanceVariable, Program.staticVariable);
        }
    }
}
