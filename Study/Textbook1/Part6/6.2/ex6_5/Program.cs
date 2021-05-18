using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";
            Console.WriteLine(txt + " EndsWith(\"WORLD\"): " + txt.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " IndexOf(\"WORLD\"): " + txt.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " Startswith(\"WORLD\"): " + txt.StartsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
            
            Console.WriteLine(txt + " == HELLO: " + (txt == "HELLO"));
            Console.WriteLine(txt + " == HELLO: " + txt.Equals("HELLO", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            string txt1 = "Hello {0}: {1}";
            string output = string.Format(txt1, "World", "Anderson");
            Console.WriteLine(output);

            string txt2 = "Hello {0}: {1}";
            Console.WriteLine(txt2, "World", "Anderson");

            string txt3 = "{2} {0} == {0} : {1}";
            Console.WriteLine(txt3, "Hello", "World", "Hi");
            Console.WriteLine();
            
            string txt4 = "{0} * {1} == {2}";
            Console.WriteLine(txt4, 5, 6, 5*6);

            string txt5 = "{0, -10} * {1} = {2, 10}";
            Console.WriteLine(txt5, 5, 6, 5*6);

            string txt6 = "날짜 : {0, -20:D}, 판매 수량 : {1, 15:N}";
            Console.WriteLine(txt6, DateTime.Now, 267);

        }
    }
}
