using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_48
{
    // enum Days
    // {
    //     Sunday = 5, Monday = 10, Tuesday, Wednesday, Thurday = 15, Friday, Saturday // Tuesday는 11, Wednesday 12, Friday 16, Saturday 17 
    // }
    [Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4, Wednesday = 8, Thurday = 16, Friday = 32, Saturday = 64// Tuesday는 11, Wednesday 12, Friday 16, Saturday 17 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Days today = Days.Sunday;
            // Console.WriteLine(today);

            // int n = (int)today;
            // short s = (short)today;

            // today = (Days)5;
            // Console.WriteLine(today); 

            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thurday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days.Sunday));
            Days today = Days.Friday;
            Console.WriteLine(workingDays.HasFlag(today));

            Console.WriteLine(workingDays);

        }
    }
}
