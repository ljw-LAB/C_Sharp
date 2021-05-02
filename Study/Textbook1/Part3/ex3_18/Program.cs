using System;

namespace ex3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for(n = 1; n <= 9; n++)
            {
                Console.WriteLine(n);
            }

            int n1 = 1;
            for(; n1 <= 9; n1++)
            {
                Console.WriteLine(n1);
            }

            int n2 = 1;
            for(; ; n2++)
            {
                if(n2 > 9)break;
                Console.WriteLine(n2);
            }

            int n3 =1;
            for(;;)
            {
                if( n3 > 9) break;
                Console.WriteLine(n3);
                n3++;
            }
        }
    }
}
