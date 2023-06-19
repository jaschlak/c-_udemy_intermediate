using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Fields
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(12);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            

            Console.WriteLine("Before re-initialization count is: {0}", customer.Orders.Count());
            customer.Promote();
            Console.WriteLine("After re-initialization count is:  {0}", customer.Orders.Count());

            Console.ReadLine();
        }
    }
}
