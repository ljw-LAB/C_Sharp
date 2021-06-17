using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            ref int b = ref a;
            int c = 6;
            b = ref c;
        }
    }
}
