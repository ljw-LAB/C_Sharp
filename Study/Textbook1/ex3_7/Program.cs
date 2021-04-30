using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool result = false;
            const int n = 5;
            const string text = "Hello";

            //result = true; 동작하지 않음. 상수이기 떄문에
            
            int n1 = Math.Max(0, 5);
            //const int maxN = Math.Max(0, 5); 동작하지 않음 컴파일
            const int n2 = 5 * 100 / 2;
            Console.WriteLine(n2);

        }
    }
}
