using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_5
{
    
    // params 가변인자의 갯수를 모를때 사용
    // 인자의 자료형을 모를때는 object로 선언
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6 , 7, 8, 9, 10));
            PrintAll(1.05, "Result", 3);
        }

        static int Add(params int[] values)
        {
            int result = 0;
            for(int i =0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }

        private static void PrintAll(params object[] values)
        {
            foreach(object value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
