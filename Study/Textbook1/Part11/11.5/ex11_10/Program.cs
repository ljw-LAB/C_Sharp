using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_10
{
    class Person
    {
        public string Name {get;set;}
        public int Age {get;set;}

        public override string ToString()
        {
            return "이름: " + Name + ", 나이: " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person{Name = "Anders", Age = 49};
            Console.WriteLine(person);
        }
    }
}
