using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_072
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int year = 2001; year <= 2100; year++)
                if(IsLeadYear(year))
                    Console.Write("{0} ", year);
            Console.WriteLine();
        }

        private static bool IsLeadYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
