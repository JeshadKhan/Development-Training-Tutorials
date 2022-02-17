using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007__Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Arithmetic Operators */
            int a = 21;
            int b = 10;
            int c;

            Console.WriteLine("Arithmetic Operators:");
            c = a + b;
            Console.WriteLine("Line 1 - Value of c is {0}", c);
            c = a - b;
            Console.WriteLine("Line 2 - Value of c is {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - Value of c is {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - Value of c is {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - Value of c is {0}", c);
            c = a++;
            Console.WriteLine("Line 6 - Value of c is {0}", c);
            c = a--;
            Console.WriteLine("Line 7 - Value of c is {0}", c);
            Console.WriteLine("\n\n");



            /* Relational Operators */
            int i = 21;
            int j = 10;

            Console.WriteLine("Relational Operators:");
            if (i == j)
            {
                Console.WriteLine("Line 1 - i is equal to j");
            }
            else
            {
                Console.WriteLine("Line 1 - i is not equal to j");
            }

            if (i < j)
            {
                Console.WriteLine("Line 2 - i is less than j");
            }
            else
            {
                Console.WriteLine("Line 2 - i is not less than j");
            }

            if (i > j)
            {
                Console.WriteLine("Line 3 - i is greater than j");
            }
            else
            {
                Console.WriteLine("Line 3 - i is not greater than j");
            }

            // Lets change value of i and j
            i = 5;
            j = 20;

            if (i <= j)
            {
                Console.WriteLine("Line 4 - i is either less than or equal to  j");
            }

            if (b >= i)
            {
                Console.WriteLine("Line 5 - j is either greater than or equal to i");
            }
            Console.WriteLine("\n\n");



            /* Logical Operators */
            bool t = true;
            bool f = true;

            Console.WriteLine("Logical Operators:");
            if (t && f)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }

            if (t || f)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }

            // lets change the value of  t and f
            t = false;
            f = true;

            if (t && f)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }

            if (!(t && f))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            Console.WriteLine("\n\n");



            /* Bitwise Operators */
            int x = 60;            /* 60 = 0011 1100 */
            int y = 13;            /* 13 = 0000 1101 */
            int z = 0;

            Console.WriteLine("Bitwise Operators:");
            z = x & y;             /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - Value of z is {0}", z);

            z = x | y;             /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - Value of z is {0}", z);

            z = x ^ y;             /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - Value of z is {0}", z);

            z = ~x;                /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - Value of z is {0}", z);

            z = x << 2;      /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - Value of z is {0}", z);

            z = x >> 2;      /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - Value of z is {0}", z);
            Console.WriteLine("\n\n");



            /* Assignment Operators */
            int r = 21;
            int s;

            Console.WriteLine("Assignment Operators:");
            s = r;
            Console.WriteLine("Line 1 - =  Value of s = {0}", s);

            s += r;
            Console.WriteLine("Line 2 - += Value of s = {0}", s);

            s -= r;
            Console.WriteLine("Line 3 - -=  Value of s = {0}", s);

            s *= r;
            Console.WriteLine("Line 4 - *=  Value of s = {0}", s);

            s /= r;
            Console.WriteLine("Line 5 - /=  Value of s = {0}", s);

            s = 200;
            s %= r;
            Console.WriteLine("Line 6 - %=  Value of s = {0}", s);

            s <<= 2;
            Console.WriteLine("Line 7 - <<=  Value of s = {0}", s);

            s >>= 2;
            Console.WriteLine("Line 8 - >>=  Value of s = {0}", s);

            s &= 2;
            Console.WriteLine("Line 9 - &=  Value of s = {0}", s);

            s ^= 2;
            Console.WriteLine("Line 10 - ^=  Value of s = {0}", s);

            s |= 2;
            Console.WriteLine("Line 11 - |=  Value of s = {0}", s);
            Console.WriteLine("\n\n");



            /* Miscellaneous Operators */
            // example of sizeof operator
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of double is {0}", sizeof(double));

            // example of ternary operator
            int o, p;
            o = 10;
            p = (o == 1) ? 20 : 30;
            Console.WriteLine("Value of p is {0}", p);

            p = (o == 10) ? 20 : 30;
            Console.WriteLine("Value of p is {0}", p);



            /* Operators Precedence */
            int a1 = 20;
            int b1 = 10;
            int c1 = 15;
            int d1 = 5;
            int e1;
            e1 = (a1 + b1) * c1 / d1;     // ( 30 * 15 ) / 5
            Console.WriteLine("Value of (a1 + b1) * c1 / d1 is : {0}", e1);

            e1 = ((a1 + b1) * c1) / d1;   // (30 * 15 ) / 5
            Console.WriteLine("Value of ((a1 + b1) * c1) / d1 is  : {0}", e1);

            e1 = (a1 + b1) * (c1 / d1);   // (30) * (15/5)
            Console.WriteLine("Value of (a1 + b1) * (c1 / d1) is  : {0}", e1);

            e1 = a1 + (b1 * c1) / d1;    //  20 + (150/5)
            Console.WriteLine("Value of a1 + (b1 * c1) / d1 is  : {0}", e1);

            Console.ReadKey();
        }
    }
}
