using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace _028__Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Viewing Metadata */
            Console.WriteLine("Viewing Metadata:\n");

            MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);

            foreach (Attribute attr in attributes)
            {
                Console.WriteLine(attr);
            }

            Console.WriteLine("\n\n");



            /* Reflection to read metadata in the Rectangle class */
            Console.WriteLine("Reflection to read metadata in the Rectangle class:\n");

            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);

            //iterating through the attribtues of the Rectangle class
            foreach (Object attrs in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attrs;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            //iterating through the method attribtues
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi = (DeBugInfo)a;
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                        Console.WriteLine("\n");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
