using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ex8_6
{
    class Person
    {
        public int Age { get; set;}
        public string Name {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
                new Person {Name = "Ally", Age = 35},
                new Person {Name = "Luis", Age = 40},
            };

            foreach(var item in list)
            {
                Console.WriteLine(item.Name + ": " + item.Age);
            }
        }
    }
}
