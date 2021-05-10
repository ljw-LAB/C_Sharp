using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 반드시 추가 할 것

namespace ex4_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {1, 2, 3, 4, 5};
            string name = "Korea";
            
            IEnumerator enumerator = intArray.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + ", ");
            }

            Console.WriteLine();

            foreach(char ch in name)
            {
                Console.Write(ch + ", ");
            }
        }
    }
}
