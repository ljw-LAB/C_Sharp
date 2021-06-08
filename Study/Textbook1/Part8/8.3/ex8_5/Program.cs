using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_5
{

    class Person
    {
        public string _name;
        int _age;

        public Person()
        {

        }

        public Person(int age)
        {
            _age =age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person(10){ _name = "Anders"};

        }
    }
}
