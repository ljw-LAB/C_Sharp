using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_43
{
    // struct Vector
    // {
    //     public int X;
    //     public int Y;
    // }
    
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Vector v1;

    //         v1.X = 5;
    //         v1.Y = 10;        

    //         Change(ref v1);
    //         Console.WriteLine("v1 : X = " + v1.X + ", Y = " + v1.Y );
    //     }

    //     static void Change(ref Vector vt)
    //     {
    //         vt.X = 7;
    //         vt.Y = 14;
    //     }
    // }

    class Point
    {
        public int X;
        public int Y;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(ref pt1);
            Console.WriteLine("v1 : X = " + pt1.X + ", Y = " + pt1.Y );
        }

        private static void Change(ref Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }
}