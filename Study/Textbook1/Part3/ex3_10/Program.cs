using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] arr2 = new int[2,3]{
                                            {1, 2, 3},
                                            {4, 5, 6}
                                        };
            int [,,]arr3 = new int[2, 3, 4]{
                                {    
                                    {1, 2, 3, 4},
                                    {5, 6, 7, 8},
                                    {9, 10, 11, 12},
                                },
                                {
                                    {13, 14, 15, 16},
                                    {17, 18, 19, 20},
                                    {21, 22, 23, 24},
                                },
            };
            int [][] arr = new int [5][];
            arr[0] = new int[10];
            arr[1] = new int[9];
            arr[2] = new int[8];
            arr[3] = new int[3];
            arr[4] = new int[5];

        }
    }
}
