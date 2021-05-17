using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_15
{
    class Program
    {
        static void Main(string[] args)
        {
            HasNoProblem();
            HasProblem();
        }

        private static void HasNoProblem()
        {
            WriteText("Argument is not NULL");
        }

        private static void HasProblem()
        {
            WriteText(null);
        }
        
        private static void WriteText(string txt)
        {
            Console.WriteLine(txt.ToLower());
        }
    }
}
