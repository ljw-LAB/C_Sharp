using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void DelegateOne();
delegate void DelegateTwo(int i);

namespace ex6_1
{
    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA ... ");
        }

        public void MethodB(int i)
        {
            Console.WriteLine("DelegateClass.MethodB, i = " + i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass obj = new DelegateClass();
            DelegateOne d1 = new DelegateOne(obj.MethodA);
            DelegateTwo d2 = new DelegateTwo(obj.MethodB);
            d1();
            d2(10);

        }
    }
}
