using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _022__Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Interfaces (you can use multi time of Interfaces define properties, methods, and events) */
            Console.WriteLine("Interfaces (you can use multi time of Interfaces define properties, methods, and events):\n");

            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
            t1.ShowTransaction();
            t2.ShowTransaction();
            Console.ReadKey();
        }
    }
}
