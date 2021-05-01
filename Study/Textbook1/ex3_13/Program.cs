using System;

namespace ex3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2 = 10;
            bool result = ( n1%3 == 0 || n2%3 == 0);
            //bool result = ( n1%3 == 0 && n2%3 == 0);

            Console.WriteLine("n1 또는 n2는 3의 배수: " + result);
        }
    }
}
