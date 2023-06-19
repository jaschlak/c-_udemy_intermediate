using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y) 
        {
            this.X = x; 
            this.Y = y;
        }

        // method overload
        public void Move(Point newLocation)
        {
            // Defensive Programming tactic
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            // this.X = newLocation.X;
            // this.Y = newLocation.Y;

            // rather than rewriting this code and defining in two places, we will just load the first method
            Move(newLocation.X, newLocation.Y);

        }
    }
}
