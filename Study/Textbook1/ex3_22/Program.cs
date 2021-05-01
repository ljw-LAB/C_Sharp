using System;

namespace ex3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n =1;

            while( n ++ <= 1000)
            {
                if( (n % 2) != 0)
                {
                    continue;
                    
                }

                sum += n;
                //Console.WriteLine(sum);
            }

            int sum1 =0;
            int n1 = 1;

            while( n1++ <= 1000)
            {
                if((n1 % 2) == 0)
                {
                    if((n1 % 3) == 0)
                    {
                        if((n1 % 5) == 0)
                        {
                            sum1+= n1;
                        }
                    }   
                }
            }
            Console.WriteLine(sum1);

            int sum2 =0;
            int n2 = 1;

            while( n2++ <= 1000)
            {
                if(( n2 % 2 ) != 0) continue;
                if(( n2 % 3 ) != 0) continue;
                if(( n2 % 5 ) != 0) continue;
                sum2+= n2;
            
            }
            Console.WriteLine(sum2);
        }
    }
}
