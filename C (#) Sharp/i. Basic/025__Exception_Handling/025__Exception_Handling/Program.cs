using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _025__Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exception Handling Division */
            Console.WriteLine("Exception Handling Division:\n");
            ExceptionHandlingDivision eh = new ExceptionHandlingDivision();
            eh.Devision(10, 0);
            Console.WriteLine("\n\n");



            /* User-Defined Exceptions */
            Console.WriteLine("User-Defined Exceptions:\n");
            TemperatureUserDefinedExceptions temp = new TemperatureUserDefinedExceptions();

            try
            {
                temp.ShowTemperature();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
