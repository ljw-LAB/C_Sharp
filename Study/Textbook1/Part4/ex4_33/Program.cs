﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex4_33
{
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
            return Name + ": " + Age;
        }
    }

    delegate bool CompareDelegate(Person arg1, Person arg2);

    class SortPerson
    {
        Person[] men;
        public SortPerson(Person[] men)
        {
            this.men = men;
        }

        public void Sort(CompareDelegate compareMethod)
        {
            Person temp;
            
            for(int i = 0; i < men.Length; i++)
            {
                int lowPos = i;
                
                for(int j = i + 1; j < men.Length; j++)
                {
                    //if(men[j].Age < men[lowPos].Age)
                    if(compareMethod(men[j], men[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = men[lowPos];
                men[lowPos] = men[i];
                men[i] = temp;
            }
        }

        public void Display()
        {
            for(int i = 0; i < men.Length; i++)
            {
                Console.WriteLine(men[i] + ",");
            }
        }
    }
    class Program
    {
        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;
            Person person2 = arg2 as Person;

            return person1.Name.CompareTo(person2.Name) < 0;
        }
        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads"),
            };

        SortPerson so = new SortPerson(personArray);
        so.Sort(AscSortByName);
        so.Display();
        }
    }
}
