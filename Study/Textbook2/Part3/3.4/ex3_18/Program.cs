using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, max =int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max + i;
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1;
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine("After checked statement");
            }    
                catch(Exception e)
                {
                    Console.WriteLine("caught an OverflowException");
                }
        }
    }
}
