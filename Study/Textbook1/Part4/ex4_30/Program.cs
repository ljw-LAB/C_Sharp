using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_30
{
    public class Mathematics
    {
        delegate int CalcDelegate(int x, int y);

        static int Add(int x, int y){return x + y;}
        static int Subtract(int x, int y){return x - y;}
        static int Multiply(int x, int y){return x * y;}
        static int Divide(int x, int y){return x / y;}

        CalcDelegate[] methods;

        public Mathematics()
        {
            methods = new CalcDelegate[]{ Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide};
        }

        public void Calculate(char opCode, int oprand1, int oprand2)
        {
            switch(opCode)
            {
                case '+':
                    Console.WriteLine("+ : "+ methods[0](oprand1, oprand2));
                    break;
                case '-':
                    Console.WriteLine("- : "+ methods[1](oprand1, oprand2));
                    break;
                case '*':
                    Console.WriteLine("* : "+ methods[2](oprand1, oprand2));
                    break;
                case '/':
                    Console.WriteLine("/ : "+ methods[3](oprand1, oprand2));
                    break;    
            }
        }
    }
    class Program
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;
            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);

        }
    }
}
