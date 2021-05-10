using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 반드시 추가 할 것

namespace ex4_37
{
    class IntegerCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if( xValue > yValue) return -1;
            else if(xValue == yValue)return 0;

            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[]{ 1, 2, 3, 4, 5};

            Array.Sort(intArray, new IntegerCompare());
            
            foreach(int item in intArray)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
