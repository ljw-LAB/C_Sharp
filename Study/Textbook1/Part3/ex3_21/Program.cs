using System;

namespace ex3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            while( n <= 1000)
            {
                if(n % 2 == 0)
                {
                    sum += n;   
                }
                n++;
            }
            Console.WriteLine(sum);

            int sum1 = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine(sum1);

            int sum2 = 0;
            int n1 =0;
            do
            {
                if(n1 % 2 == 0) sum2 += n1;

            }while(++n1 <= 1000);
            Console.WriteLine(sum2);

        }
    }
}
