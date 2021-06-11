using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_5
{
    public class Vector
    {
        double x;
        double y;

        public double Angle => Math.Atan2(y, x);

        public double this[string angleType] =>
            angleType == "radian" ? this.Angle :
            angleType == "degree" ? RadianToDegree(this.Angle) : double.NaN;
        
        static double RadianToDegree(double angle) => angle * (180.0 / Math.PI);

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
