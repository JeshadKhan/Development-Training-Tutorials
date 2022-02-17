using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006__Constants_and_Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const double pi = 3.14159;

            double r;
            Console.Write("Enter Radius:\t");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadKey();
        }
    }
}
