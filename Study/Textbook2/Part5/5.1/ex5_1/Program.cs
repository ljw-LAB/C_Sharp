using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_1
{
    class Fraction
    {
        private int numerator;
        private int denmoinator;

        public int Numerator
        {
            get{ return numerator;}
            set{ numerator = value; }
        }

        public int Denmoinator
        {
            get{ return denmoinator;}
            set{ denmoinator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denmoinator);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Fraction f = new Fraction(); int i;
           f.Numerator = 1;
           i = f.Numerator + 1;
           f.Denmoinator = i;
           Console.WriteLine(f.ToString());
        }
    }
}
