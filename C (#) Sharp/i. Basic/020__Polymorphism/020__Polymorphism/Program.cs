using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _020__Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Static Polymorphism (Function Overloading) */
            Console.WriteLine("Static Polymorphism (Function Overloading):\n");
            PrintData p = new PrintData();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello String");

            Console.WriteLine("\n\n");



            /* Dynamic Polymorphism (Abstract Classes) */
            Console.WriteLine("Dynamic Polymorphism (Abstract Classes):\n");
            AbstractRectangle ar = new AbstractRectangle(10, 7);
            Console.WriteLine("Rectangle area: {0}", ar.area());
            Console.WriteLine("\n\n");



            /* Static Polymorphism (Virtual Functions) */
            Console.WriteLine("Static Polymorphism (Virtual Functions):\n");

            VirtualRectangle vr = new VirtualRectangle(9, 7);
            VirtualTriangle vt = new VirtualTriangle(9, 7);

            Caller call = new Caller();
            call.CallArea(vr);
            call.CallArea(vt);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
