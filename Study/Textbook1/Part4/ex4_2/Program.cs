using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2
{
    class Mathematics
    {
        public int GetAreaofSquare(int x)
        {
            return x*x;
        }

        public int GetValue()
        {
            return 10;
        }

        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaofSquare(m.GetValue());
            Console.WriteLine(result);
        }
    }

}