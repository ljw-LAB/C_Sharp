using System;

namespace ex3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            Console.WriteLine(n++);

            n = 50;
            Console.WriteLine(++n);

            int n1 = 50;
            int result;

            result = n1++;
            Console.WriteLine(result);

            n1 = 50;
            result = ++n1;
            Console.WriteLine(result);

            n1 = 50;
            result = n1--;
            Console.WriteLine(result);
            
            n1 = 50;
            result = --n1;
            Console.WriteLine(result);
            
        }
    }
}
