﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate bool CompareDelegate(int arg1, int arg2);

namespace ex4_32
{
    class SortObject
    {
        int[] numbers;
        public SortObject(int[] numbers)
        {
            this.numbers = numbers;       
        }

        // public void Sort(bool ascending)
        // {
        //     int temp;
            
        //     for(int i = 0; i < numbers.Length; i++)
        //     {
        //         int lowPos = i;

        //         for(int j = i + 1; j < numbers.Length ; j++ )
        //         {
        //             if(ascending == true)
        //             {
        //                 if(numbers [j] < numbers[lowPos])
        //                 {
        //                     lowPos = j;
        //                 }
        //             }
        //             else
        //             {
        //                 if(numbers [j] > numbers[lowPos])
        //                 {
        //                     lowPos = j;
        //                 }
        //             }

                    
        //         }

        //         temp = numbers[lowPos];
        //         numbers[lowPos] = numbers[i];
        //         numbers[i] = temp;
        //     }
        // } 
        public void Sort(CompareDelegate compareMethod)
        {
            int temp;
            for(int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;
                for(int j = i + 1; j < numbers.Length ; j++ )
                {
                    if(compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }
                
                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for(int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ", ");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray= new int[] {5, 2, 3, 1, 0, 4};
            SortObject so = new SortObject(intArray);
            so.Sort(AssendingCompare);
            so.Display();
            Console.WriteLine();

            so.Sort(DescendingCompare);
            so.Display();
        }

        public static bool AssendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }

}
