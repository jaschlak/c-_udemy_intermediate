using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Inheritance
{

    internal class Program
    {
        static void Main()
        {
            // Text inherits PresentationObject
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Duplicate();
            text.AddHyperLink("https://www.fridaypage.com");
            Console.ReadLine();
        }
    }
}
