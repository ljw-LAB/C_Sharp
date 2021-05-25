using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 반드시 추가 할 것

namespace ex6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Hello");
            ar.Add("World");
            ar.Add("My");
            ar.Add("Sample");

            ar.Sort();

            foreach(string txt in ar)
            {
                Console.WriteLine(txt);
            }
        }
    }
}
