using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Methods
{

    internal class Program
    {

        static void Main(string[] args)
        {

            //var number = int.Parse("abc");  // failed parse


            int number;
            // Generic built in try
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            } else
            {
                Console.WriteLine("Conversion Failed");
            }
            Console.ReadLine();

        }

        static void UseParams()
        {
            // example of array input
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 202));
            Console.WriteLine(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.ReadLine();
        }

        static void UsePoints()
        {
            // explicit try statement
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(30, 70));
                Console.WriteLine("The location is at {0},{1}", point.X, point.Y);


                // use method overload
                point.Move(200, 42);
                point.Move(null);
                Console.WriteLine("The location is at {0},{1}", point.X, point.Y);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured");
                Console.ReadLine();
            }
        }
    }
}
