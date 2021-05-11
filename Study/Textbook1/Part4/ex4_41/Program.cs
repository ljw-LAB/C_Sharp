using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_41
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

            Vector v2= v1;

            v2.X = 7;  // 내용 추가 
            v2.Y = 14; // 내용 추가

            //Point pt1 = new Point();
            //pt1.X = 6;
            //pt1.Y = 12;

            //Point pt2 = pt1;

            Console.WriteLine("v1 : X = " + v1.X + ", Y = " + v1.Y );
            Console.WriteLine("v2 : X = " + v2.X + ", Y = " + v2.Y );

            Console.WriteLine();

            Point pt1 = new Point();
            pt1.X = 5;
            pt1.Y = 10;

            Point pt2 = pt1;

            pt2.X = 7;
            pt2.Y = 14;

            Console.WriteLine("v1 : X = " + pt1.X + ", Y = " + pt2.Y );
            Console.WriteLine("v2 : X = " + pt2.X + ", Y = " + pt2.Y );

        }
    }
}
