using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_3
{
    class Person
    {
        string _name;
        int _age;

        public Person() : this(string.Empty, 0)
        {

        }

        public Person(string name) : this(name, 0)
        {

        }

        public Person(string name, int age)
        {
            _age = age;
            _name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Anders", 10);
        }
    }
}
