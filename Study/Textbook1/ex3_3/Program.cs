using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            Console.WriteLine(ch);

            char ch1 = '\t';
            char ch2 = 'T';
            char ch3 = '\n';
            char ch4 = 'o';

            Console.Write(ch1);
            Console.Write(ch2);
            Console.Write(ch3);
            Console.Write(ch4);

            char ch5 = '\u2023'; // 윈도우 명령 프롬포트는 유니코드 문자를 출력 x, 따라서 ? 출력됨
            Console.Write(ch5);

            char ch6 = '\\';
            Console.Write(ch6);

            string text = "\tHello\nWorld";
            Console.WriteLine(text);

            string text1 = "\"Hello World\"";
            Console.WriteLine(text1);
            
            string text2 = @"\tHello\nWorld";
            Console.WriteLine(text2);

            bool isNumeric = false;
            Console.WriteLine(isNumeric);
        }
    }
}
