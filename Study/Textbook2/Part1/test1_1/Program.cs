﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_1
{
    delegate void Delegate();
    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("In the Method 1...");
        }

        public static void Method2()
        {
            Console.WriteLine("In the Method 2...");   
        }

        static void Main(string[] args)
        {
            Delegate d = new Delegate(Method1);
            d += new Delegate(Method2);
            d();
        }
    }
}
