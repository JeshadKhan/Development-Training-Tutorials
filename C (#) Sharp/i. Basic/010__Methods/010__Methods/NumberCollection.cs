using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010__Methods
{
    class NumberCollection
    {
        /* Define the method */

        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        public int FindMin(int num1, int num2)
        {
            int result;

            if (num1 < num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        public int Factorial(int num)
        {
            int result;

            if (num==1)
            {
                return 1;
            }
            else
            {
                // Recursive Method (it call itself)
                result = Factorial(num - 1) * num;
                return result;
            }
        }
    }
}
