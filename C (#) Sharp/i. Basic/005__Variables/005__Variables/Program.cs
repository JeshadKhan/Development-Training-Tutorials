using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005__Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // define variable as data_type and data_list
            int i;
            char ch;
            double d, salary;

            // define variable with values
            float f = 10.11f;
            byte by = 22;
            double pi = 3.1416;
            char x = 'x', y = 'y';

            // VariableDefinition 
            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
