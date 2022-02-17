using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.Generic;

namespace _034__Generics
{
    class Program
    {
        // Generic Method
        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        // Generic Delegates
        delegate T NumberChanger<T>(T n);

        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }

        // Main Function or Method
        static void Main(string[] args)
        {
            /* Generic Class */
            Console.WriteLine("Generic Class:\n");

            GenericArray<int> intArray = new GenericArray<int>(5);

            // Setting values
            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i * 5);
            }

            // Retrieving the values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }

            Console.WriteLine();
            GenericArray<char> charArray = new GenericArray<char>(5);

            // Setting values
            for (int i = 0; i < 5; i++)
            {
                charArray.SetItem(i, (char)(i + 97));
            }

            // Retrieving the values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(charArray.GetItem(i).ToString().ToUpper() + " ");
            }

            Console.WriteLine("\n\n\n");



            /* Generic Methods */
            Console.WriteLine("Generic Methods:\n");

            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'A';
            d = 'M';

            // Display values before swap
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            // Call swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            // Display values after swap:
            Console.WriteLine("\nInt values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            Console.WriteLine("\n\n");



            /* Generic Delegates */
            Console.WriteLine("Generic Delegates:\n");

            // Create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            // Calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", GetNum());
            Console.ReadKey();
        }
    }
}
