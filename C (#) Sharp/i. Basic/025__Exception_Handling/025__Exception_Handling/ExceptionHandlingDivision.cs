using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _025__Exception_Handling
{
    class ExceptionHandlingDivision
    {
        int result;

        public ExceptionHandlingDivision()
        {
            result = 0;
        }

        public void Devision(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
