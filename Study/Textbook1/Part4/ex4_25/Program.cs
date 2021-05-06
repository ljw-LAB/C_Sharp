using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_25
{
    // class Mathematics
    // {
    //     public int AbsInt(int value)
    //     {
    //         return (value >= 0) ? value : -value;
    //     }
    //     public int AbsDouble(double value)
    //     {
    //         return (value >= 0) ? value : -value;
    //     }
    //     public int AbsDecimal(Decimal value)
    //     {
    //         return (value >= 0) ? value : -value;
    //     }
    // }

    class Mathematics
    {
        public int Abs(int value)
        {
            return (value >= 0) ? value : -value;
        }
        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }
        public Decimal Abs(Decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(20.01m));

        }
    }
}
