using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
        }

        struct Vector
        {
            public int X;
            public int Y;

            public Vector(int x, int y)
            {
                X = x; 
                Y = y;
            }
        }
        class Matrix
        {
            public Vector Rx = new Vector(1, 2);
            public Vector Ry = new Vector(10, 20);

        }
    }
}
