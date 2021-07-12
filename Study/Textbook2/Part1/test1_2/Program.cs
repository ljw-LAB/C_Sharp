using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 0, k;
            try
            {
                Console.WriteLine("Exception checking...");
                k = i / j;
                Console.WriteLine("After Exception happenning...");
            }
            catch(Exception e)
            {
                Console.WriteLine("Caught Exception...");
            }
            finally
            {
                Console.WriteLine("In the finally statement...");
            }
        }
    }
}
