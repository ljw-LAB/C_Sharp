using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_8
{
    class XBool
    {
        public bool b;
        public static explicit operator bool(XBool x)
        {
            Console.WriteLine("In the explicit operator bool ... ");
            return x.b;
        }

        public static bool operator true(XBool x)
        {
            Console.WriteLine("In the explicit operator true ... ");
            return x.b ? true : false;
        }

        public static bool operator false(XBool x)
        {
            Console.WriteLine("In the explicit operator false ... ");
            return x.b ? false : true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XBool xb = new XBool();
            xb.b = false;
            if(xb)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine((bool)xb);


        }
    }
}
