using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019__Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Multiple Inheritance */
            Rectangle rect = new Rectangle();
            rect.SetWidth(5);
            rect.SetHeight(7);
            int area = rect.GetArea();

            Console.WriteLine("Total area: {0}", rect.GetArea());
            Console.WriteLine("Total paint cost: ${0}", rect.GetCost(area));

            Console.ReadKey();
        }
    }
}
