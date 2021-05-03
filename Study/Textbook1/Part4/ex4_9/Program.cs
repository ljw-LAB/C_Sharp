﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_9
{
    class Person
    {
        static public int CountOfInstance;
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.CountOfInstance);
            Person person1 = new Person("홍길동");
            //Console.WriteLine(person1.CountOfInstance);

            Person person2 = new Person("홍길순");
            //Console.WriteLine(person2.CountOfInstance);
            Console.WriteLine(Person.CountOfInstance);

        }
    }
}
