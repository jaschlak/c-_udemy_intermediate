using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Fields
{
    public class Customer
    {
        public int Id;
        public string Name;

        // contstructor initialization
        public List<Order> Orders = new List<Order>();

        // If readonly, can only be initialized once in the same object, otherwise throws error
        //public readonly List<Order> Orders = new List<Order>();

        // contstructor initialization
        public Customer(int id)
        {
            this.Id = Id;
        }

        // Overloaded contstructor initialization
        public Customer(int id, string Name)
            : this(id)              // not best pracice
        {
            this.Name = Name;
        }

        public void Promote()
        {
            // This is shows reinitialization destroys older Order lists
            Orders = new List<Order>();
        }
    }
}
