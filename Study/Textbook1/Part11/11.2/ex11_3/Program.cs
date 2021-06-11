using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_3
{
    public class Vector
    {
        double x;
        double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector Move(double dx, double dy) => new Vector(x+dx, y+dx);

        public void PrintIt() => Console.WriteLine(this);

        public override string ToString() => string.Format(" x = {0}, y = {1}", x, y);

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
