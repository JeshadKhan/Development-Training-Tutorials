using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009__Encapsulation_Access_Specifier_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Public Access Specifier */
            Console.WriteLine("Public Access Specifier:\n");
            PublicRectangle publicR = new PublicRectangle();
            publicR.length = 4.5;
            publicR.width = 3.5;
            publicR.Display();
            Console.WriteLine("\n\n");



            /* Private Access Specifier */
            Console.WriteLine("Private Access Specifier:\n");
            PrivateRactangle privateR = new PrivateRactangle();
            //privateR.length2 = 4.5;
            //privateR.width2 = 3.5;
            privateR.Acceptdetails();
            privateR.Display();
            Console.WriteLine("\n\n");



            /* Internal Access Specifier */
            Console.WriteLine("Internal Access Specifier:\n");
            InternalRactangle internalR = new InternalRactangle();
            internalR.length = 4.5;
            internalR.width = 3.5;
            internalR.Display();
            Console.WriteLine("\n\n");
        }
    }
}
