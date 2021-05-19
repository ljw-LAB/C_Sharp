using System;
using System.IO;
using System.Text; // 추가해야함

namespace ex6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buf = Encoding.UTF8.GetBytes("Hello World");
            ms.Write(buf, 0, buf.Length);

            StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
            sw.WriteLine("Hello World");
            sw.WriteLine("Anderson");
            sw.WriteLine(32000);
            sw.Flush();

            ms.Position = 0;
            StreamReader sr= new StreamReader(ms, Encoding.UTF8);
            string txt = sr.ReadToEnd();
            Console.WriteLine(txt);
        }
    }
}
