using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_10
{
    interface IRectangle
    {
        void Area(int width, int height);
    }

    interface ITriangle
    {
        void Area(int width, int height);
    }

    class Shape : IRectangle, ITriangle
    {
        void IRectangle.Area(int width, int height)
        {
            Console.WriteLine("Rectangle Area : " + width*height);
        }

        void ITriangle.Area(int width, int height)
        {
            Console.WriteLine("Triangle Area : " + (width*height)/2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            ((IRectangle)s).Area(20, 20);
            ((ITriangle)s).Area(20, 20);
            IRectangle r = s;
            ITriangle t = s;
            r.Area(30,30);
            t.Area(30,30);
        }
    }
}
