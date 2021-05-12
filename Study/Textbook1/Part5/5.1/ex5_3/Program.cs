using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc(0x01, 10, 5);
            Calc(0x02 | 0x04 | 0x08, 10, 5);
        }

        private static void Calc(int op, int operand1, int operand2)
        {
            if((op & 0x01) == 0x01)
            {
                Console.WriteLine(operand1 + operand2);
            }

            if((op & 0x02) == 0x02)
            {
                Console.WriteLine(operand1 - operand2);
            }

            if((op & 0x04) == 0x04)
            {
                Console.WriteLine(operand1 * operand2);
            }

            if((op & 0x08) == 0x08)
            {
                Console.WriteLine(operand1 / operand2);
            }
        }
    }
}
