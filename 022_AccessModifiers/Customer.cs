using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }
        }

        // when CalculateRating is private, it cannot be seen by Main
        // when CalcualteRating is protected, it can be seen by Main
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
