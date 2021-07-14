using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_7
{
    class Complex
    {
        private double realPort;
        private double imagePort;

        public Complex(double rVal, double iVal)
        {
            realPort = rVal;
            imagePort = iVal;
        }

        public static Complex operator+(Complex x1, Complex x2)
        {
            Complex x = new Complex(0, 0);
            x.realPort = x1.realPort + x2.realPort;
            x.imagePort = x1.imagePort + x2.imagePort;
            return x;
        }
        public override string ToString()
        {
            return "(" + realPort + "," + imagePort + "i)";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c, c1, c2;
            c1 = new Complex(1, 2);
            c2 = new Complex(3, 4);
            c = c1 + c2;
            Console.WriteLine(c1 + " + " + c2 + " = " + c);
        }
    }
}
