using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _035__Anonymous_Methods
{
    delegate void NumberChanger(int n);

    class Program
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Addition Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Multiplication Method: {0}", num);
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            /* Anonymous Methods */
            Console.WriteLine("Anonymous Methods:\n");

            //create delegate instances using anonymous method
            NumberChanger nc = delegate(int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //calling the delegate using the anonymous method 
            nc(10);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods 
            nc(5);

            //instantiating the delegate using another named methods 
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods 
            nc(2);

            Console.ReadKey();
        }
    }
}
