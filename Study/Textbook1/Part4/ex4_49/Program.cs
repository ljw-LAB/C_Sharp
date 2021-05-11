using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_49
{

    enum CalcType { Add, Minus, Multiply, Divide }


    class Program
    {
        // int Calc(char opType, int operand1, int operand2)
        // {
        //     switch(opType)
        //     {
        //         case '+' : return operand1 + operand2;
        //         case '-' : return operand1 - operand2;
        //         case '*' : return operand1 * operand2;
        //         case '/' : return operand1 / operand2;
        //     }
            
        //     return 0;
        // }
        
        static int Calc(CalcType opType, int operand1, int operand2)
        {
            switch(opType)
            {
                case CalcType.Add : return operand1 + operand2;
                case CalcType.Minus : return operand1 - operand2;
                case CalcType.Multiply : return operand1 * operand2;
                case CalcType.Divide : return operand1 / operand2;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(CalcType.Add, 5, 6));
        }
    }
}
