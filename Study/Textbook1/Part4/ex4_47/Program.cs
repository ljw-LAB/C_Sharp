﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            if(int.TryParse("1234567", out n) == true)
            {
                Console.WriteLine(n);
            }

            double d;
            if(double.TryParse("12E3", out d) == true)
            {
                Console.WriteLine(d);
            }
            
            bool b;
            if(bool.TryParse("true", out b) == true)
            {
                Console.WriteLine(b);
            }
            
            short s;
            if(short.TryParse("123456789", out s) == true)
            {
                Console.WriteLine(s);
            }
            
            if(short.TryParse("Not_a_number", out s) == true)
            {
                Console.WriteLine(s);
            }
        }
    }
}
