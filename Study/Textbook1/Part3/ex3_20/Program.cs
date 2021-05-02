using System;

namespace ex3_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[] {1, 2, 3, 4, 5};

            foreach (int elem in arr)
            {
                Console.WriteLine(elem);
            }

            for(int i = 0; i < 5 ; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
