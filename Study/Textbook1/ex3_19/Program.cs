using System;

namespace ex3_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 2; x < 10; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    Console.WriteLine(x+"*"+ y +"=" + (x*y));
                }
            }
        }
    }
}
