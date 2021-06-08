using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_8
{
    partial class myTest
    {
        partial void Log(object obj);

        public void WriteTest()
        {
            this.Log("call test!");
        }
    }

    partial class myTest
    {
        partial void Log(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myTest t = new myTest();
            t.WriteTest();
        }
    }
}
