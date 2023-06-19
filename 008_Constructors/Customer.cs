using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overload 1
        public Customer(int id)
            : this() // loads base constructor
        {
            this.Id = id;
        }

        // Overload 2
        public Customer(int id, string name)
            : this(id) // loads constructor above, which loads base constructor, not best practice
        {
            this.Id = id;
            this.Name = name;
        }

    }


}
