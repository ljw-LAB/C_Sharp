﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_046
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            double sum = 0;

            for(int i =0; i < 5; i++)
            {
                Console.Write("키를 입력하세요(단위 : cm) : ");
                double h = double.Parse(Console.ReadLine());
                if(h > max)
                    max = h;
                else
                    min = h;
                sum += h;
            }
            Console.WriteLine("평균 : {0}cm, 최대 : {1}cm, 최소 : {2}cm", sum /5, max, min);
        }
    }
}
