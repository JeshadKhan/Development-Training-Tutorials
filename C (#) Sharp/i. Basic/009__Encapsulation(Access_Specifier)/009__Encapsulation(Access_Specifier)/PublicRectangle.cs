using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009__Encapsulation_Access_Specifier_
{
    class PublicRectangle
    {
        /* Public Access Specifier */
        
        public double length;
        public double width;

        public double Area()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", Area());
        }
    }
}
