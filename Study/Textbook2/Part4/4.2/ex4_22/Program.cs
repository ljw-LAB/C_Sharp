using System;

namespace ex4_22
{
    class BassClass
    {
        public void MethodA()
        {
            Console.WriteLine("do BaseClass Task. ");
        }
    }

    class DerivedClass : BassClass
    {
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("do DerivedClass Task. ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.MethodA();
        }
    }
}
