using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_3
{
    class Program
    {
        readonly Vector v1 = new Vector();
        static void Main(string[] args)
        {
            Program pg = new Program();
            StructParam(pg.GetVector());
        }

        private static void StructParam(in Vector v)
        {
            v.Increment(1, 1);
        }

        private Vector GetVector()
        {
            return v1;
        }

        readonly struct Vector
        {
            readonly public int X;
            readonly public int Y;

            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Vector Increment(int x, int y)
            {
                return new Vector(X+x, Y+y);
            }

        }
    }
}
