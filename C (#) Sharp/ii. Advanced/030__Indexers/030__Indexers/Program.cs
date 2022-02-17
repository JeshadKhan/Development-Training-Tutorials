using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _030__Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Use of Indexers */
            Console.WriteLine("Use of Indexers:\n");

            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            // using the first indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n\n");



            /* Overloaded Indexers */
            Console.WriteLine("Overloaded Indexers:\n");

            // using the second indexer with the string parameter
            Console.WriteLine(names["Nuha"]);

            Console.ReadKey();
        }
    }
}
