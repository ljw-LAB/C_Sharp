using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

class YieldNaturalNumber
{
    public static IEnumerable<int> Next(int max)
    {
        int _start = 0;
        while(true)
        {
            _start++;
            if(max < _start)
            {
                yield break;
            }

            yield return _start;
        }
    }
}

namespace ex7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int n in YieldNaturalNumber.Next(100000))
            {
                Console.WriteLine(n);
            }
        }
    }
}
