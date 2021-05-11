using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_40
{
    struct Vector
    {
        public int X;
        public int Y;
        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "X: " + X + ", Y = " + Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Vector v2;

            Vector v3 = new Vector(5, 10);

            Console.WriteLine(v3);
        }
    }
}
