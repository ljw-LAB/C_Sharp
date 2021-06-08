using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_4
{
    class Person
    {
        string _name;
        int _age;

        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public int Age
        {
            get{return _age;}
            set{_age = value;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person{ Name = "Anders" };
            Person p3 = new Person{ Age = 10};
            Person p4 = new Person{ Name = "Anders", Age = 10};

        }
    }
}
