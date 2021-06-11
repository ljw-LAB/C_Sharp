using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using static MyDay;
using static BitMode;
using static System.Console;

public enum MyDay
{
    Saturday, Sunday,
}

public class BitMode
{
    public const int ON = 1;
    public const int OFF = 0;

}

namespace ex11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDay day = Saturday;
            int bit = ON;

            WriteLine(day);
            WriteLine(bit);
        }
    }
}