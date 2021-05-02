using System;

namespace ex3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            int n1 = value %3;
            int n2 = value %5;

            bool orReult = (n1 == 0 || n2 == 0);
            Console.WriteLine("value는 3의 배수이거나 5의 배수 : " + orReult);

            bool andReult = (n1 == 0 && n2 == 0);
            Console.WriteLine("value는 3과 5의 배수 : " + andReult);
            
            bool notReult = !(n1 == 0);
            Console.WriteLine("value는 3의 배수가 아님 : " + notReult);
            
        }
    }
}
