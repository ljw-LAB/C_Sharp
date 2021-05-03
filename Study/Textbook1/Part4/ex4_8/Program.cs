using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_8
{
    class Person
    {
        public string _name;
        public Person(string name)
        {
            _name = name;
        }
        public void OutputYourName()
        {
            Console.WriteLine(_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("홍길동");
            person.OutputYourName();
            Console.WriteLine(person._name);
        }
    }
}
