using System;

namespace ex3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            if(6 % 3 == 0)
            {
                Console.WriteLine("6은 3의 배수 ");
                Console.WriteLine("연산 결과 끝 ! ");
            }

            int value = 5;
            if(value % 2 == 0)
            {
                Console.WriteLine("value는 2의 배수");
                Console.WriteLine("따라서 value는 짝수");
            }
            else
            {
                Console.WriteLine("value는 홀수");
            }

            if(value <= 255)
            {
                Console.WriteLine("byte 변환 가능");
            }
            else if(value <= 65535)
            {
                Console.WriteLine("ushort 변환 가능");
            }
            else
            {
                Console.WriteLine("int 타입");
            }

            string result1;
            if(value %2 == 0)
            {
                result1 = "짝수";
            }
            else
            {
                result1 = "홀수";
            }

            Console.WriteLine(result1);

            string result2 = (value % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result2);

        }
    }
}
