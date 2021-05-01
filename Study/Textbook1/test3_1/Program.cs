using System;

namespace test3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            for(n = 0; n<1000; n++)
            {
                if((n % 3) == 0 || (n % 5) == 0)
                {
                    sum+= n;
                }
            }
            Console.WriteLine(sum);

            int n1 = 0, sum1 =0;
            while(n < 1000)
            {
                if(n%3 == 0 || n%5 == 0)
                {
                    sum += n;
                }
                n++;
            }

            Console.WriteLine(sum);
        }
    }
}
