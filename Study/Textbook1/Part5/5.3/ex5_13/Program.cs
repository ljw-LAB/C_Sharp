using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int divisor = 0;
            //int divisor = 10;
            // try
            // {
            //     int quotient = 10 / divisor;
            // }
            // catch
            // {
            //     Console.WriteLine("예외가 발생하면 실행됨!");
            // }
            // finally
            // {
            //     Console.WriteLine("언제나 실행됨");
            // }

            // try
            // {
            //     int quotient = 10 / divisor;
            // }
            // catch(System.DivideByZeroException)
            // {
            //     Console.WriteLine("예외가 발생하면 실행됨!");
            // }

            string txt = null;
            int divisor = 0;

            // try
            // {

            // Console.WriteLine(txt.ToUpper());
            // int quotient = 10 / divisor;
            // }
            // catch (System.DivideByZeroException)
            // {
            // Console.WriteLine("예외가 발생하면 실행됨!"); //txt예외가 먼저 발생되어 실행되지 않음, * int quotient = 10 / divisor; 먼저 실행되면 실행 됨.            
            // }

            try
            {
                int quotient = 10 / divisor;
                Console.WriteLine(txt.ToUpper());
            }
            //catch(System.Exception){Console.WriteLine("예외가 발생하면 실행됨!");} // 에러 발생, 밑에 있는 Catch구문의 포괄하고 이씅ㅁ
            catch(System.NullReferenceException){Console.WriteLine("NULL 예외가 발생하면 실행됨!");}
            catch(System.DivideByZeroException){Console.WriteLine("0으로 나누는 예외가 발생하면 실행됨!");}
            catch(System.Exception){Console.WriteLine("예외가 발생하면 실행됨!");}
        }
    }
}
