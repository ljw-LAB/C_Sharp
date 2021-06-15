using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr =new byte[] {0, 1, 2, 3, 4, 5, 6, 7};

            var arrLeft = arr.Take(4).ToArray();
            var arrRight = arr.Skip(4).ToArray(); 

            Print(arrLeft);
            Print(arrRight);

        }

        private static void Print(Span<byte> view)
        {
            foreach( byte elem in view)
            {
                Console.WriteLine(elem + ", ");
            }
            Console.WriteLine();
        } 
    }
}
