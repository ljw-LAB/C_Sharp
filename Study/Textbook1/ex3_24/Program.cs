using System;

namespace ex3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;

            for(int x = 2; x < 10; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    Console.WriteLine(x + "*" + y + "=" +(x*y));
                    exitLoop = x == 5 && y == 8;
                    if(exitLoop == true)
                    {
                        break;
                    }
                }

                if(exitLoop == true)
                {
                    break;
                }
            }
            
            for(int x1 = 2; x1 < 10; x1++)
            {
                for(int y1 = 1; y1 < 10; y1++)
                {
                    Console.WriteLine(x1 + "*" + y1 + "=" +(x1*y1));
                    if(x1== 5 && y1 ==8)goto LOOP_EXIT;
                }
            }

            LOOP_EXIT: ;
        }
    }
}
