using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _029__Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Property Accessors */
            Console.WriteLine("Property Accessors:\n");

            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);

            // let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}
