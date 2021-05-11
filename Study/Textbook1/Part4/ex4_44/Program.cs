using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_44
{
    class Point
    {
        public int X;
        public int Y;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = null;

            change1(pt1);
            //Console.WriteLine("pt1 : X =  " + pt1.X + ", Y = " + pt1.Y);
            Console.WriteLine("pt1: " + pt1);

            change2(ref pt1);
            Console.WriteLine("pt1 : X =  " + pt1.X + ", Y = " + pt1.Y);
            //Console.WriteLine("pt1: " + pt1);

        }

        private static void change1(Point pt)
        {
            pt = new Point();

            pt.X = 6;
            pt.Y = 12;

        }

        private static void change2(ref Point pt)
        {
            pt = new Point();

            pt.X = 7;
            pt.Y = 14;
        }
    }
}
