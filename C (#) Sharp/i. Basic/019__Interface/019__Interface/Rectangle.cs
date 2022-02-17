using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019__Interface
{
    // Multiple Inheritance
    class Rectangle : Shape,ICost
    {
        public int GetArea()
        {
            return width * height;
        }

        public int GetCost(int area)
        {
            return area * 70;
        }
    }
}
