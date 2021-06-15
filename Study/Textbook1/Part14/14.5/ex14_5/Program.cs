using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NuGet 패키지 관리자에서 SYSTEM.Memory를 설치 할 것 
namespace ex14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new byte[] {0, 1, 2, 3, 4, 5, 6};

            Span<byte> view = arr;
            Console.WriteLine(view[5]);

            view[5] = 17;
            Console.WriteLine(arr[5]);

            
            arr[5] = 15;
            Console.WriteLine(view[5]);
            
        }
    }
}
