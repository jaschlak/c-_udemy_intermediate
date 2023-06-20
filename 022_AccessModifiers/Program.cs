using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon;

namespace _022_AccessModifiers
{

    internal class Program
    {
        static void Main()
        {
            var customer = new Customer();
            Amazon.RateCalculator rateCalculator = new RateCalculator();
        }
    }
}
