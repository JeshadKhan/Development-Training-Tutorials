using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018__Inheritance
{
    // Derived Class inherit Base Class
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }

        public Rectangle(){}

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public void Display()
        {
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
