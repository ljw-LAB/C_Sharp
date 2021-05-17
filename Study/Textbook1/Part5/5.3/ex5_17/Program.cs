using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HasProblem();
            }
            catch (System.Exception ex)
            {
                throw; // ex보다는 이렇게 쓰는 것을 추천, 예외를 발생시킨 호출 스택이 모두 출력됨, ex는 코드가 발생한 지점부터 호출 스택 출력
                //throw ex;
            }
        }
        private static void HasProblem()
        {
            string txt = null;
            Console.WriteLine(txt.ToUpper());
        }
    }
}
