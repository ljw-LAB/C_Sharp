using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Color{Red, Green, Blue};

namespace ex2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.Red;
            c++;
            int i = (int) c;
            Console.WriteLine("Cardinality of " + c + " = " + i);
        }
    }
}
