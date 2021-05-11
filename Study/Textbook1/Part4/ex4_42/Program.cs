using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_42
{
    struct Vector
    {
        public int X;
        public int Y;
    }

    class Point
    {
        public int X;
        public int Y;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(v1);
            Console.WriteLine("v1 : X = " + v1.X + ", Y = " + v1.Y );
        
            Point pt1 = new Point();
            pt1.X = 5;
            pt1.Y = 10;

            Change_1(pt1);
            Console.WriteLine("v1 : X = " + pt1.X + ", Y = " + pt1.Y );
        
        }

        private static void Change(Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }
        private static void Change_1(Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }
}
