using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _027__Attributes
{
    class Program
    {
        /* Conditional Attributes Method */

        static void function1()
        {
            ConditionalAttributes.Message("In Function 1.");
            function2();
        }

        static void function2()
        {
            ConditionalAttributes.Message("In Function 2.");
        }



        /* Obsolete */

        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }

        public static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }



        /* Main Method */

        static void Main(string[] args)
        {
            /* Conditional Attributes */
            Console.WriteLine("Conditional Attributes:\n");
            ConditionalAttributes.Message("In Main function.");
            function1();
            Console.WriteLine("\n\n");



            /* Obsolete */
            Console.WriteLine("Obsolete:\n");
            OldMethod();
            Console.ReadKey();
        }
    }
}
