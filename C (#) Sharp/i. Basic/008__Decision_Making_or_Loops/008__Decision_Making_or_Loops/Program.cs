using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008__Decision_Making_or_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if...else statement */
            int a = 10;
            Console.WriteLine("if...else statement:\n");

            if (a < 20)
            {
                // if condition is true then print the following
                Console.WriteLine("a is less than 20");
            }

            Console.WriteLine("value of a is : {0}", a);
            Console.WriteLine("\n\n");



            /* switch...case statement */
            int i = 100;
            int j = 200;
            Console.WriteLine("switch...case statement:\n");

            switch (i)
            {
                case 100:
                    Console.WriteLine("This is part of outer switch ");
                    switch (j)
                    {
                        case 200:
                            Console.WriteLine("This is part of inner switch ");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Default statement is generated.");
                    break;
            }

            Console.WriteLine("Exact value of i is : {0}", i);
            Console.WriteLine("Exact value of j is : {0}", j);
            Console.WriteLine("\n\n");



            /* for loop */
            Console.WriteLine("for loop:\n");

            for (int f = 10; f < 20; f = f + 1)
            {
                Console.WriteLine("value of f: {0}", f);
            }

            Console.WriteLine("\n\n");



            /* while loop */
            int w = 10;
            Console.WriteLine("while loop:\n");

            while (w < 20)
            {
                Console.WriteLine("value of w: {0}", w);
                w++;
            }

            Console.WriteLine("\n\n");



            /* do...while loop */
            int dw = 10;
            Console.WriteLine("do...while loop:\n");

            do
            {
                Console.WriteLine("value of dw: {0}", dw);
                dw = dw + 1;
            } while (dw < 20);

            Console.WriteLine("\n\n");



            /* infinity loop */
            Console.WriteLine("infinity loop:\n");

            for (; ; )
            {
                //Console.WriteLine("Hey! I am Infinity loop.");
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
