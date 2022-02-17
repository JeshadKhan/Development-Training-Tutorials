using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _012__Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Nullable Types */
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();

            Console.WriteLine("Nullable Types:\n");
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.WriteLine("\n\n");



            /* The Null Coalescing Operator (??) */
            double? numb1 = null;
            double? numb2 = 3.14157;
            double numb3;

            Console.WriteLine("The Null Coalescing Operator (??):\n");

            numb3 = numb1 ?? 5.34;
            Console.WriteLine("Value of numb3: {0}", numb3);

            numb3 = numb2 ?? 5.34;
            Console.WriteLine("Value of numb3: {0}", numb3);

            Console.ReadKey();
        }
    }
}
