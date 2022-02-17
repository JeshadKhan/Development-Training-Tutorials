using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010__Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection nc = new NumberCollection();


            /* Call the method */
            Console.WriteLine("Method Example:\n"); 
            Console.WriteLine("Maximum Number: " + nc.FindMax(10, 20));
            Console.WriteLine("Minimum Number: " + nc.FindMin(10, 20));
            Console.WriteLine("\n\n");


            /* Recursive Method Call */
            Console.WriteLine("Recursive Method Example (it call itself):\n");
            Console.WriteLine("Factorial 2 is: " + nc.Factorial(2));
            Console.WriteLine("Factorial 7 is: " + nc.Factorial(7));
            Console.WriteLine("Factorial 9 is: " + nc.Factorial(9));
            Console.ReadKey();
        }
    }
}
