using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Indexers
{
    internal class Program
    {
        static void Main()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Moshie";
            Console.WriteLine("The cookie name is {0}", cookie["name"]);
            Console.ReadLine();
        }
    }
}
