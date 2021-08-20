using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_074
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);

        }

        static void DrawPyramid(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                for(int j = i; j < n; j++)
                    Console.Write(" ");
                for(int k = i; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
