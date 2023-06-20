using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Properties
{
    public class Person
    {

        public string Name { get; set; }
        public string UserName { get; set; }

        public DateTime Birthdate { get; private set; }

        // With Birthdate having a private setter, you cannot set it without the Person constructor below

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


        public string dude { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
