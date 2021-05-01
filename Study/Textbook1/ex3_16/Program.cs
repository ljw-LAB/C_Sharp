using System;

namespace ex3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "C#";
            switch(test)
            {
                case "C#" :
                case "VB.NET" :
                    Console.WriteLine(".NET 호환 언어");
                    break;
                case "Java" :
                    Console.WriteLine("JVM 언어");
                    break;
                default :
                    Console.WriteLine("알 수 없음");
                    break;
            }
            
            if(test == "C#" || test == "VB.NET")
            {
                Console.WriteLine(".NET 호환 언어");

            }
            else if(test == "Java")
            {
                Console.WriteLine("JVM 언어");
            }
            else
            {
                Console.WriteLine("알 수 없음");
            }
        }
    }
}
