using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ex15_3
{
    class Program
    {
        public class Point
        {
            public int X;
            public int Y;
            
            public ref int GetPinnableReference()
            {
                return ref X;
            }
        }
        static void Main(string[] args)
        {
            Point pt = new Point();
            unsafe
            {
                fixed (int* pPoint = pt)
                {
                    Console.WriteLine(*pPoint);
                }
            }
            //unsafe문으로 감싸줘야 컴파일 에러 일어나지 않음
        }
    }
}
