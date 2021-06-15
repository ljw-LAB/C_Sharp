using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_2
{
    class Program
    {
        readonly Vector v1 = new Vector();
        static void Main(string[] args)
        {
            Program pg = new Program();
            // pg.v1.X = 5; 컴파일 오류
            pg.v1.Increment();
            Console.WriteLine(pg.v1.X + ", " + pg.v1.Y );
        }
    }
    
    struct Vector
    {
//        public int X;
//        public int Y;
        readonly public int X;
        readonly public int Y;


        public void Increment()
        {
            //X++;
            //Y++;
        }   
    }
}
