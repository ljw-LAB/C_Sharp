﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_10
{
    class Program
    {
        public delegate int IntStringDelegate(string txt);
        public delegate string StringObjectDelegate(object obj);

        static void Main(string[] args)
        {
            // C# 7.2까지 컴파일 오류 - Error CS0121 The call is ambiguous between the following methods or properties: 'Program.Call(Program.IntStringDelegate)' and 'Program.Call(Program.StringObjectDelegate)'
            Call(RetIntArgObject);

            // C# 7.2까지 컴파일 오류 - Error CS0121 The call is ambiguous between the following methods or properties: 'Program.Call(Program.IntStringDelegate)' and 'Program.Call(Program.StringObjectDelegate)'
            Call(RetStringArgObject);
        }

        public static void Call(IntStringDelegate func)
        {
            Console.WriteLine("IntStringDelegate");
        }

        public static void Call(StringObjectDelegate func)
        {
            Console.WriteLine("StringObjectDelegate");
        }

        private static int RetIntArgObject(object txt)
        {
            return 5;
        }

        private static string RetStringArgObject(object txt)
        {
            return txt.ToString();
        }

    }
}
