using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _017__Classes
{
    class Line
    {
        private double length;   // Length of a line

        // Constructor (the class name and the method name is same)
        public Line()
        {
            Console.WriteLine("Object is being created");
        }

        // Parameterized constructor (constructor with parameter)
        public Line(double len)
        {
            Console.WriteLine("Object is being created, length = {0}", len);
            length = len;
        }

        // Destructor (it delete the object that finished the work)
        // Destructor can be very useful for releasing memory resources before exiting the program.
        ~Line()
        {
            Console.WriteLine("Object is being deleted");
        }

        // Set the length (no return type)
        public void setLength(double len)
        {
            length = len;
        }

        // Get the length (return type must needed)
        public double getLength()
        {
            return length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* First Length */
            Console.WriteLine("First Length:\n");

            // Create instance or object
            Line line = new Line();

            // set line length
            line.setLength(6.0);

            // get line length
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.WriteLine("\n\n");



            /* Second Length */
            Console.WriteLine("Second Length:\n");

            // Create instance or object & set line length by parameterized constructor
            Line line2 = new Line(10.0);

            // get line length
            Console.WriteLine("Length of line : {0}", line2.getLength());
            Console.WriteLine("\n\n");



            /* Static Members */
            // Static variable
            Console.WriteLine("Static variable:\n");
            StaticClassTester s1 = new StaticClassTester();
            StaticClassTester s2 = new StaticClassTester();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.WriteLine("\n\n");

            // Static method
            Console.WriteLine("Static method:\n");
            StaticClassTester s = new StaticClassTester();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("Variable num: {0}", StaticClassTester.getNumStatic());
            Console.ReadKey();
        }
    }
}
