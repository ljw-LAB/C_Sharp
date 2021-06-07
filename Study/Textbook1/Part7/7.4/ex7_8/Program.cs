using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class YieldNaturalNumber
{
    public static IEnumerable<int> Next()
    {
        int _start = 0;
        while(true)
        {
            _start++;
            yield return _start;
        } 
    }
}

namespace ex7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int n in YieldNaturalNumber.Next())
            {
                Console.WriteLine(n);
            }
        }
    }
}
