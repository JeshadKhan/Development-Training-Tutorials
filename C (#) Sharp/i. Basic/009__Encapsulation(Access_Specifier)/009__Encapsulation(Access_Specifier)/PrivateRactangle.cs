using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009__Encapsulation_Access_Specifier_
{
    class PrivateRactangle
    {
        /* Private Access Specifier */
        
        private double length;
        private double width;

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

        public void Acceptdetails()
        {
            Console.Write("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
    }
}
