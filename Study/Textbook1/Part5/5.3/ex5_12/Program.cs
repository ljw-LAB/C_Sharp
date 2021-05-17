using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //string txt =null;
            //string upper = txt.ToUpper(); // 아무것도 담기지 않은 변수에 To Upper멤버 메소드 호출로 인한 예외 발생

            int[] intArray = new int[10];
            int lastElem = intArray[11];    // 배열 인덱스 범위 초과로 인한 에러 발생
        }
    }
}
