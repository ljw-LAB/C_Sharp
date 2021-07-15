using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MultiDelegate();

namespace ex6_3
{
    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA ... ");
        }

        public void MethodB()
        {
            Console.WriteLine("In the DelegateClass.MethodB ... ");
        }

        public void MethodC()
        {
            Console.WriteLine("In the DelegateClass.MethodC ... ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass obj = new DelegateClass();
            MultiDelegate dg1, dg2, dg3;
            dg1 = new MultiDelegate(obj.MethodA);
            dg2 = new MultiDelegate(obj.MethodB);
            dg3 = new MultiDelegate(obj.MethodC);

            dg1 = dg1 + dg2;
            dg1 += dg3;
            dg2 = dg1 - dg2;
            dg1();
            Console.WriteLine("After dg1 call ... ");
            dg2();
            Console.WriteLine("After dg2 call ... ");
            dg3();
        }
    }
}
