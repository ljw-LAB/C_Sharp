﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = new int[] { 1, 2, 3, 4, 5 };
            List<string> strings = new List<string>();
            strings.Add("Anders");
            strings.Add("Hejlsberg");

            foreach(int n in intList)
            {
                Console.Write(n + ",");
            }
            Console.WriteLine();

            foreach (string txt in strings)
            {
                Console.Write(txt + " ");
            }

        }
    }
}
