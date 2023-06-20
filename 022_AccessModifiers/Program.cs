using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
    internal class Program
    {
        static void Main()
        {
            var customer = new Customer();
        }
    }
}
