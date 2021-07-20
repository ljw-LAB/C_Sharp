using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_26
{
    class Program
    {
        void Orange()
        {
            int i = 25, j =0;
            i = i/j;
            Console.WriteLine("End of Orange method");
        }

        void Apple()
        {
            Orange();
            Console.WriteLine("End of Apple method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            try{
                p.Apple();
            }catch(ArithmeticException)
            {
                Console.WriteLine("ArithmeticException is processed");
            }
            Console.WriteLine("End of Main");
        }
    }
}
