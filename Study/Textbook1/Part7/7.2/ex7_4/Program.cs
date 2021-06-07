using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt =null;

            if(txt == null)
            {
                Console.WriteLine("(null)");
            }
            else
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine(txt ?? "(null)");
        }
    }
}
