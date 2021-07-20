using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_25
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            while(true)
            {
                try{
                    if(++count == 1)throw new Exception();
                    if(count == 3) break;
                    Console.WriteLine(count + ") No exception");
                }
                catch (Exception)
                {
                    Console.WriteLine(count + ") Exception thrown");
                }
                finally
                {
                    Console.WriteLine(count + ") in finally clause");
                }
            }
            Console.WriteLine("Main Program ends");
        }
    }
}
