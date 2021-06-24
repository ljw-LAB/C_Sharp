using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_14
{
    class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("In the constructor... ");

        }
        ~Destructor()
        {
            Console.WriteLine("In the denstructor... ");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Destructor d = new Destructor();
            Console.WriteLine("End of Main");
        }
    }
}
