using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Properties
{

    internal class Program
    {
        static void Main()
        {
            /* This code no longer works because the birthdate setter is private
            var person = new Person();
            person.Birthdate = new DateTime(1962, 1, 1);
            */

            // Instead we need to use the constructor
            var person = new Person(new DateTime(1962, 1, 1));

            Console.WriteLine("persons age is {0}", person.Age);
            Console.ReadLine();
        }
    }
}
