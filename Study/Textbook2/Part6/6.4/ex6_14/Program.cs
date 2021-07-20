#define CSHARP

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ex6_14
{
    class Program
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }

        [Conditional("JAVA")]
        public static void JAVAMethod()
        {
            Console.WriteLine("In the JAVA Method ...");
        }

        static void Main(string[] args)
        {
            Program.CsharpMethod();
            Program.JAVAMethod();   
        }
    }
}
