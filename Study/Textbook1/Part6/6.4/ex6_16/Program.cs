using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(32, "Cooper");
            s1.Add(56, "Anderson");
            s1.Add(17, "Sammy");
            s1.Add(27, "Paul");

            foreach(int key in s1.GetKeyList())
            {
                Console.WriteLine(string.Format("{0} {1}", key, s1[key]));
            }
        }
    }
}
