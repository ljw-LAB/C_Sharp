using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_8
{
    delegate void SampleDelegate();
    class DelegateClass
    {
        public void DelegateMethod()
        {   
            Console.WriteLine("In the DelegateClass.DelegateMethod...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass obj = new DelegateClass();
            SampleDelegate sd = new SampleDelegate(obj.DelegateMethod);
            sd();
        }
    }
}
