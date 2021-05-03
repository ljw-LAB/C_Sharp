using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_10
{
    class Person
    {
        static public Person President = new Person("대통령"); 
        string _name;
        private Person(string name)
        {
            _name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }
        
    class Program
    {
        
        static void Main(string[] args)
        {
            Person.President.DisplayName();
            //Person person1 = new Person("홍길동");
        }
    }
}
