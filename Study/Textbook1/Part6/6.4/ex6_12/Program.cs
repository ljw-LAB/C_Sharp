using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 반드시 추가 할 것

namespace ex6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Hello");
            ar.Add(6);
            ar.Add("World");
            ar.Add(true);

            Console.WriteLine("Contains(6) : " + ar.Contains(6));
            ar.Remove("World");
            ar[2] = false;
            Console.WriteLine();
            foreach(object obj in ar)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
