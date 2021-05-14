using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_11
{
    class Program
    {
        static void AccessArray(int [] array)
        {
            array[5] =0;
        }
        static void Main(string[] args)
        {
            int [] nArray = new int [] {0, 1, 2, 3, 4};
            //nArray[5] = 0;//예외 발생
            AccessArray(nArray);
        }
    }
}
