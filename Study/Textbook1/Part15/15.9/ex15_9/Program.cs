using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_9
{
    public class AmbiguousMethods
    {
        public static GenericResult<T> Do<T>(Func<T> func)
        {
            Console.WriteLine("GenericResult<T> Do");
            T inst = func();
            return new GenericResult<T>(inst);
        }

        public static int Do(Func<int> func)
        {
            Console.WriteLine("int Do");
            return func();
        }
    }

    public class GenericResult<T>
    {
        T _inst;
        public GenericResult(T inst)
        {
            _inst = inst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AmbiguousMethods.Do(GetInteger);
            AmbiguousMethods.Do(GetString);
            Task.Run(SumOfIntegers);
        }

        private static int GetInteger()
        {
            return 5;
        }
        private static string GetString()
        {
            return "test";
        }

        private static int SumOfIntegers()
        {
            return Enumerable.Range(1, 1000).Sum();
        }
    }
}
