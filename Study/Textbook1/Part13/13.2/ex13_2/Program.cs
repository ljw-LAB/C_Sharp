using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ex13_2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int intValue = default;
        //    BigIntger bitIntValue = default;

        //    Console.WriteLine(intValue);
        //    Console.WriteLine(bitIntValue);

        //    string text = default;
        //    Console.WriteLine(text ?? "(null)");
        //}

        static void Main(string[] args)
        {
            GenericTest<int> t = new GenericTest<int>();
            Console.WriteLine(t.GetDefaultValue());

            int intValue = default;
            BigInteger bigIntValue = default;

            Console.WriteLine(intValue);        // 출력 결과: 0
            Console.WriteLine(bigIntValue);     // 출력 결과: 0

            string txt = default;
            Console.WriteLine(txt ?? "(null)"); // 출력 결과: (null)
        }

        class GenericTest<T>
        {
            public T GetDefaultValue()
            {
                return default;
            }
        }
    }
}
