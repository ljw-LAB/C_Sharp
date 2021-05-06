using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_26
{
    public class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString()
        {
            return mass + "kg";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1.Add(kg2);

            Console.WriteLine(kg3);
        }
    }
}
