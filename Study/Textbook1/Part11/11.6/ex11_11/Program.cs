using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ex11_11
{
    class Person
    {
        public string Name {get;set;}
        public int Age {get;set;}

        public override string ToString()
        {
            return $"이름 : {Name}, 나이 : {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {Name = "Anders", Age = 49};
            OutputPerson(person.Name, person.Age);

            string typeName = nameof(Person);
            WriteLine($"{typeName} 속성 : {nameof(person.Name)}, {nameof(person.Age)}");            
        }

        static void OutputPerson(string name, int age)
        {
            string methodName = nameof(OutputPerson);

            WriteLine($"{methodName}.{nameof(name)} == {name}");
            WriteLine($"{methodName}.{nameof(age)} == {age}");

            string localName = name;
            WriteLine($"{methodName}.{nameof(localName)} == {localName}");
        }
    }
}
