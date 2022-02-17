using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013__Arrays
{
    class MyArray
    {
        public double GetAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }

        public int AddElementsToParamArray(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }
}
