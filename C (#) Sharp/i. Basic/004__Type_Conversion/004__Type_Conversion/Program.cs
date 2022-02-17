using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeConversionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implicit type conversion */
            int i = 500;
            double d;
            d = i;
            Console.WriteLine("Implicit type conversion:");
            Console.WriteLine(d + "\n\n");



            /* Explicit type conversion */
            double d2 = 5678.90;
            int i2;

            //cast double to integer
            i2 = (int)d2;
            Console.WriteLine("Explicit type conversion:");
            Console.WriteLine(i2 + "\n\n");



            /* String Conversion */
            int i3 = 75;
            float f3 = 53.005f;
            double d3 = 2345.7652;
            bool b3 = true;

            Console.WriteLine("String Conversion:");
            Console.WriteLine(i3.ToString());
            Console.WriteLine(f3.ToString());
            Console.WriteLine(d3.ToString());
            Console.WriteLine(b3.ToString());
            Console.ReadKey();
        }
    }
}
