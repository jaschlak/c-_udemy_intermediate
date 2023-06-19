using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Jeremy");



            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();

        }
    }
}
