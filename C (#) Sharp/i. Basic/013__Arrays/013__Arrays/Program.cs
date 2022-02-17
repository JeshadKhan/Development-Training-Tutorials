using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaring Arrays */
            double[] balance = new double[10];
            balance[0] = 45.50;

            double[] balance2 = { 45.50, 47.60, 23.99 };

            double[] balance3 = new double[3] { 45.50, 47.60, 23.99 };

            double[] balance4 = new double[] { 45.50, 47.60, 23.99 };



            /* Copy an Array to another Array */
            double[] salary = balance;



            /* Declaration, Assignment, and Accessing Arrays */
            int[] num = new int[5];
            int i, j;

            Console.WriteLine("Array Example (Declaration, Assignment, and Accessing):\n");

            // setting value in array
            for (i = 0; i < num.Length; i++)
            {
                num[i] = i + 100;
            }

            // getting value in array
            for (j = 0; j < num.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, num[j]);
            }

            Console.WriteLine("\n\n");



            /* Multi-Dimensional Arrays */
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } }; // [row, column]. Here 5 rows and 2 columns.
            int m, n;

            Console.WriteLine("Multi-Dimensional Arrays:\n");

            for (m = 0; m < 5; m++)
            {
                for (n = 0; n < 2; n++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", m, n, a[m, n]);
                }
            }

            Console.WriteLine("\n\n");



            /* Jagged Arrays (arrays of array) */
            int[][] b = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };
            int o, p;

            Console.WriteLine("Jagged Arrays (arrays of array):\n");

            for (o = 0; o < 5; o++)
            {
                for (p = 0; p < 2; p++)
                {
                    Console.WriteLine("b[{0}][{1}] = {2}", o, p, b[o][p]);
                }
            }

            Console.WriteLine("\n\n");



            /* Passing Arrays as Function Arguments */
            int [] amount = new int[]{1000, 2, 3, 17, 50};
            MyArray myArray = new MyArray();
            double avg = myArray.GetAverage(amount, amount.Length);

            Console.WriteLine("Passing Arrays as Function Arguments:\n");
            Console.WriteLine("Average value is: {0} ", avg);
            Console.WriteLine("\n\n");



            /* Param Arrays (unknown number of parameters array) */
            MyArray myArray2 = new MyArray();
            int sum = myArray.AddElementsToParamArray(512, 720, 250, 567, 889);

            Console.WriteLine("Param Arrays (unknown number of parameters array):\n");
            Console.WriteLine("The sum is: {0}", sum);

            Console.ReadKey();
        }
    }
}
