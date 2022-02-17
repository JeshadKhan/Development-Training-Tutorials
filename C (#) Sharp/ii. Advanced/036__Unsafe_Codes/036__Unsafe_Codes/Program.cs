using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _036__Unsafe_Codes
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            /* Pointer Variables */
            Console.WriteLine("Pointer Variables:\n");

            int p = 20;
            int* q = &p;

            Console.WriteLine("Data is: {0} ", p);
            Console.WriteLine("Address is: {0}", (int)q);
            Console.WriteLine("\n\n");



            /* Retrieving the Data Value Using a Pointer */
            Console.WriteLine("Retrieving the Data Value Using a Pointer:\n");

            unsafe
            {
                int var1 = 20;
                int* var2 = &var1;
                Console.WriteLine("Data is: {0} ", var1);
                Console.WriteLine("Data is: {0} ", var2->ToString());
                Console.WriteLine("Address is: {0} ", (int)var2);
            }

            Console.WriteLine("\n\n");



            /* Passing Pointers as Parameters to Methods */
            Console.WriteLine("Passing Pointers as Parameters to Methods:\n");

            TestPointer tp = new TestPointer();
            int v1 = 10;
            int v2 = 20;
            int* x = &v1;
            int* y = &v2;

            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", v1, v2);
            tp.Swap(x, y);

            Console.WriteLine("After Swap: var1:{0}, var2: {1}", v1, v2);
            Console.WriteLine("\n\n");



            /* Accessing Array Elements Using a Pointer */
            Console.WriteLine("Accessing Array Elements Using a Pointer:\n");

            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }

            Console.ReadKey();
        }
    }
}
