using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _016__Enumeration
{
    class Program
    {
        // Enum list item value starts by default from 0
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            // Pick the items value from the list
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            // Display the items value of the enum called "Day"
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }
}
