#define PI
#define DEBUG
#define JK

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//#define PI //cannot define/undefine preprocessor symbols after first token in file

namespace _023__Preprocessor_Directives
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The #define Preprocessor */
            Console.WriteLine("The #define Preprocessor:\n");
#if (PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.WriteLine("\n\n");



            /* Conditional Directives */
            Console.WriteLine("Conditional Directives:\n");
#if (DEBUG && !JK)
            Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && JK)
         Console.WriteLine("JK is defined");
#elif (DEBUG && JK)
            Console.WriteLine("DEBUG and JK are defined");
#else
         Console.WriteLine("DEBUG and JK are not defined");
#endif
            Console.ReadKey();
        }
    }
}
