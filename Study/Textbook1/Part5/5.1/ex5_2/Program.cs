using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =38;
            int leftShiftResult = n << 2;
            int rightShiftResult = n >> 2;

            Console.WriteLine(leftShiftResult);
            Console.WriteLine(rightShiftResult);

            int n1 = -38; // 음수 경우,  우측 쉬프트시 유의해야함
            int rightShiftResult_1 = n1 >> 2;
            
            Console.WriteLine(rightShiftResult_1);

        }
    }
}
