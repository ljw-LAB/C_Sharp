using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            for(i = 1; i <= n; ++i)
                h = h + 1/(double)i;
            Console.WriteLine(" n = {0}, h = {1}", n ,h);
        }
    }
}
