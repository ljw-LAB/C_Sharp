using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_043
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for(int i = 1; i<= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("1부터 100까지 숫자의 합은 {0}", sum);

            int sum2 = 0;
            for(int x =1; x<= 100; x++)
            {
                if(x % 2 == 1)
                    sum += x;
            }
            Console.WriteLine("1부터 100까지 홀수의 합은 {0}", sum2);

            double sum3 =0;
            for(int x = 1; x<= 100; x++)
            {
                sum3 += 1.0/x;
            }
            Console.WriteLine("1부터 100까지 역수의 합은 {0}", sum3);

        }
    }
}
