using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003__Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Value types */
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadKey();


            /* Reference types */
            // Object Type
            object obj;
            obj = 100; //this is boxing

            // Dynamic Type
            dynamic variablename = 200;

            // String Type
            string str = "This is a string";
            string str2 = @"This is another string";


            /* Pointer types */
            //char* cptr;
            //int* iptr;
        }
    }
}
