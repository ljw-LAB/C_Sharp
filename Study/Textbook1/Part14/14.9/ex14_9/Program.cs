using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Output(name : "Tom", 16, address: "Tibet");
        }
    }

    class Person
    {
        public void Output(string name, int age = 0, string address = "Korea")
        {
            Console.WriteLine(string.Format("{0} : {1} in {2}", name, age, address));
        }
    }
}
