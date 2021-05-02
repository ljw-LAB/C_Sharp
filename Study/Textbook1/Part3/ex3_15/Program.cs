using System;

namespace ex3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'F';

            switch(ch)
            {
                case 'M' :
                    Console.WriteLine("남성");
                    break;
                case 'F' :
                    Console.WriteLine("여성");
                    break;
                default  :
                    Console.WriteLine("알 수 없음");
                    break;        
            }

            if(ch == 'M')
            {
                Console.WriteLine("남성");

            }
            else if(ch == 'F')
            {
                Console.WriteLine("여성");

            }
            else
            {
                Console.WriteLine("알 수 없음");

            }
        }
    }
}
