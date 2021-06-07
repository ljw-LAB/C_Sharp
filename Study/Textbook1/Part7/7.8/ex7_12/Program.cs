using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
static class StaticOnly
{
    static string _name;
    public static string Name
    {
        get { return _name;}
        set { _name = value;}
    }

    public static void WriteNameAsync()
    {
        ThreadPool.QueueUserWorkItem(delegate(object objState)
        {
            Console.WriteLine(_name);
        });
    }
}

namespace ex7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticOnly.Name = "Anders";
            StaticOnly.WriteNameAsync();
            Thread.Sleep(1000);
        }
    }
}
