using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class ExtensionMethodSample
{
    public static int GetWordCount(this string txt)
    {
        return txt.Split(' ').Length;
    }
}

namespace ex8._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";
            Console.WriteLine("Count: " + text.GetWordCount());
        }
    }
}
