using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_12
{
    class Program
    {
        delegate int MyAdd(int a, int b);
        static void Main(string[] args)
        {
            MyAdd myFunc = (a, b) => a+b;
            Console.WriteLine("10 + 2 == " + myFunc(10, 2));
        }
    }
}
