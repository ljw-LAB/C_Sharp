﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex5_19
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCreate();

            Console.WriteLine("파일이 열려 있습니다");
            Console.ReadLine();
        }
        private static void FileCreate()
        {
            FileStream fs = new FileStream("output.log", FileMode.Create);
        }
    }
}
