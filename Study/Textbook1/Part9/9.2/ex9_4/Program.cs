﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ex9_4
{
class Program
{
    static void Main(string[] args)
    {
        // string 메서드의 Contains 메서드 호출
        {
            string txt = "Test Func";
            bool result = txt.Contains("Test");
            Console.WriteLine(result);
        }

        // 리플렉션을 이용한 string 메서드의 Contains 메서드 호출
        {
            string txt = "Test Func";
            Type type = txt.GetType();
            MethodInfo containsMethodInfo = type.GetMethod("Contains");
            if (containsMethodInfo != null)
            {
                object returnValue = containsMethodInfo.Invoke(txt, new object[] { "Test" });
                bool callResult = (bool)returnValue;
                Console.WriteLine(callResult);
            }
        }

        // dynamic을 이용한 string 메서드의 Contains 메서드 호출
        {
            dynamic txt = "Test Func";
            bool result = txt.Contains("Test");
            Console.WriteLine(result);
        }
    }
}
}
