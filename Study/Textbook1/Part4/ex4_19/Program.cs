using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_19
{
    class Program
    {
        private static void OutputArrayInto(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " +arr.Rank);
            Console.WriteLine("배열의 요소 수 : " +arr.Length);
            Console.WriteLine();
        } 

        private static void OutputArrayElement(string title, Array arr)
        {
            Console.WriteLine("["+ title + "]");
            for(int i =0; i < arr.Length ; i++)
            {
                Console.WriteLine(arr.GetValue(i) + ",");
            }

            Console.WriteLine();
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,]{{true, false}, {false, false}};
            OutputArrayInto(boolArray);

            int[] intArray = new int[] {5, 4, 3, 2, 1, 0};
            OutputArrayInto(intArray);

            OutputArrayElement("원본 intArray", intArray);
            Array.Sort(intArray);
            OutputArrayElement("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);

            OutputArrayElement("intArray로부터 복사된 copyArray", copyArray);

        }
    }
}
