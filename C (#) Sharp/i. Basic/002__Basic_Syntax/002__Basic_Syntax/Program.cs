using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002__Basic_Syntax
{
    /* Rectangle Class */
    class Rectangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length:\t{0}", length);
            Console.WriteLine("Width:\t{0}", width);
            Console.WriteLine("Area:\t{0}", GetArea());
        }
    }

    /* Main Class */
    class ExecuteRactangle
    {
        static void Main(string[] args)
        {
            /* create Rectangle class object */
            Rectangle r = new Rectangle();

            /* set length & width value */
            r.AcceptDetails();

            /* displaying calculation */
            r.Display();

            Console.ReadKey();
        }
    }
}
