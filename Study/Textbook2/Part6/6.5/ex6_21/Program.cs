using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_21
{
    class Program
    {
        public static void Exp(int ptr)
        {
            if(ptr == 0)
                throw new NullReferenceException();
        }
        static void Main(string[] args)
        {
            int i = 0;
            Program.Exp(i);
        }
    }
}
