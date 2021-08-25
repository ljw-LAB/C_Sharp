﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_063
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[30];

            for(int i = 0; i < 30; i++)
                v[i] = r.Next(1000);            
            PrintArray("정렬 전", v);

            Array.Sort(v);
            PrintArray("정렬 후", v);

            Console.Write("=> 검색할 숫자를 입력하세요: ");
            int key = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 0; i < v.Length; i++)
            {
                count++;
                if(v[i] == key)
                {
                    Console.WriteLine("v[{0}] = {1}", i, key);
                    Console.WriteLine("선형탐색의 비교횟수는 {0}회입니다. ", count);
                    break;
                }
            }

            count = 0;
            int low = 0;
            int high = v.Length - 1;
            while(low <= high)
            {
                count++;
                int mid = (low+high)/2;
                if(key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                }
            }
        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for(int i = 0; i < v.Length; i++)
                Console.Write("{0, 5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
        }
    }
}