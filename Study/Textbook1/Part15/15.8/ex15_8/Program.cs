using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_8
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int* pArray1 = stackalloc int[3] {1, 2, 3};
            int* pArray2 = stackalloc int[] {1, 2};

            Span<int> span1 = stackalloc int[3] { 1, 2, 3 };
            Span<int> span2 = stackalloc int[] { 1, 2 };

        }
    }
}
