﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_1
{
    class Mathematics
    {
        public int f(int x)
        {
            return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.f(5);
            Console.WriteLine(result);
        }
    }
}