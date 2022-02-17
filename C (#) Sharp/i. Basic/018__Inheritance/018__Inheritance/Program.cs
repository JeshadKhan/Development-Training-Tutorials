using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Use of Base Class and Derived Class - Inheritance */
            Console.WriteLine("Use of Base Class and Derived Class - Inheritance:\n");
            // Create instance or object of Derived Class
            Rectangle rect = new Rectangle();

            // Set width & height
            rect.SetWidth(5);
            rect.SetHeight(10);

            // Get area
            Console.WriteLine("Rectangle area: {0}", rect.GetArea());
            Console.WriteLine("\n\n");



            /* Override Base Class */
            Console.WriteLine("Override Base Class:\n");
            OverrideBaseClass obc = new OverrideBaseClass(50,60);
            obc.Display();
            Console.ReadKey();
        }
    }
}
