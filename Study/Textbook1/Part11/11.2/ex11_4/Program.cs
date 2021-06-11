using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_4
{
    public class Vector
    {
        public double x;
        public double y;

        public double Angle => Math.Atan2(y, x);

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
