using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> logOut = 
            (txt) =>
            {
                Console.WriteLine(DateTime.Now + ": " + txt);
            };

            logOut("This is my world!");

            Func<double> pi = () => 3.141592;

            Console.WriteLine(pi());
        }
    }
}
