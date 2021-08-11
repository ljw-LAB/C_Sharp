﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string result = (input > 0) ? "양수입니다." : "음수입니다.";
            Console.WriteLine("{0}는 {1}", input, result);
            Console.WriteLine("{0}는 {1}", input, (input % 2 == 0) ? "홀수입니다." : "짝수입니다.");

            for(int i = 1; i <= 50; i++)
            {
                Console.Write("{0,3}{1}", i, i % 10 !=0 ? "" : "\n");
            }

        }
    }
}
