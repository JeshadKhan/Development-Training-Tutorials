using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011__Passing_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            /* Passing Parameters by Value */
            ValueParameters valueParameters = new ValueParameters();
            Console.WriteLine("Passing Parameters by Value:\n");
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            valueParameters.Swap(a, b); // Value Parameters
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.WriteLine("\n\n");



            /* Passing Parameters by Reference */
            ReferenceParameters referenceParameters = new ReferenceParameters();
            Console.WriteLine("Passing Parameters by Reference:\n");
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            referenceParameters.Swap(ref a, ref b); // Reference Parameters
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.WriteLine("\n\n");



            /* Passing Parameters by Output */
            OutputParameters outputParameters = new OutputParameters();
            Console.WriteLine("Passing Parameters by Reference:\n");
            Console.WriteLine("Before method call, value of a : {0}", a);
            outputParameters.GetValue(out a); // Output Parameters
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
}
