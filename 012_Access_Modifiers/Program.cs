using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Access_Modifiers
{
    public class Person
    {
        // variable is private, needs getter/setter
        private DateTime _birthdate;

        // setter
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        // getter
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            // access private variable value with encapsulation
            person.SetBirthdate(new DateTime(1975, 7, 13));
            Console.WriteLine("birthday set to {0}", person.GetBirthdate());
            Console.ReadLine(); 
        }
    }
}
