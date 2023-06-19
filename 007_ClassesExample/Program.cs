using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ClassesExample
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance method example
            Person person = new Person();
            person.Name = "John Instance";
            person.Introduce("Mosh");

            // static method example
            Person staticperson = Person.Parse("Johnny Static");
            staticperson.Introduce("BillyBob");

            Console.ReadLine();
        }
    }
}
