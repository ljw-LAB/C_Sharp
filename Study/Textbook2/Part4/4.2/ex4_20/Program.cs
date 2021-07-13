using System;

namespace ex4_20
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base Method A");
        }

        virtual public void MethodB()
        {
            Console.WriteLine("Base Method B");
        }

        virtual public void MethodC()
        {
            Console.WriteLine("Base Method C");
        }
    }

    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("DerivedClass MethodA");
        }

        override public void MethodB()
        {
            Console.WriteLine("DerivedClass MethodB");
        }
        public void MethodC()
        {
            Console.WriteLine("DerivedClass MethodC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass s = new DerivedClass();
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}
