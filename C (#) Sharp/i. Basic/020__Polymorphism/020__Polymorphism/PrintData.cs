using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _020__Polymorphism
{
    class PrintData
    {
        /* Static Polymorphism (Function Overloading) */

        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
