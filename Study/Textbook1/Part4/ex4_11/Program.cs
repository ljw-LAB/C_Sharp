using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_11
{
    class Person
    {
        static int CountOfInstance;
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }
        static public void OutputCount()
        {
            Console.WriteLine(CountOfInstance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.OutputCount();
            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");
            Person.OutputCount();//
        }
    }
}
