using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ex6_11
{
    [Serializable]
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Age, this.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(36, "Anderson");
            BinaryFormatter bf = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, person);

            ms.Position = 0;

            Person clone = bf.Deserialize(ms) as Person;
            Console.WriteLine(clone);
        }
    }
}
