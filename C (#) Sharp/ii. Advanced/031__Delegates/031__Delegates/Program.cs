using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace _031__Delegates
{
    class Program
    {
        /* Delegate */
        delegate int NumberChanger(int n);



        /* Necessary variables and methods */
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }



        /* Using Delegates */

        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void printString(string s);

        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        // this method prints to a file
        public static void WriteToFile(string str)
        {
            fs = new FileStream("sample.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine();
            sw.Flush();

            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as parameter and uses it to
        public static void SendString(printString s)
        {
            s("Hello, World!");
        }



        /* Main Method or Function */
        static void Main(string[] args)
        {
            /* Declaring Delegates */
            Console.WriteLine("Declaring Delegates:\n");

            NumberChanger ncAdd = new NumberChanger(AddNum);
            ncAdd(25);
            Console.WriteLine("Value of Num (Addition): {0}", getNum());

            NumberChanger ncMul = new NumberChanger(MulNum);
            ncMul(5);
            Console.WriteLine("Value of Num (Multiply): {0}", getNum());

            Console.WriteLine("\n\n");



            /* Multicasting of a Delegate */
            Console.WriteLine("Multicasting of a Delegate:\n");

            // create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);

            Console.WriteLine("Value of Num (Multicast): {0}", getNum());
            Console.WriteLine("\n\n");



            /* Using Delegates */
            Console.WriteLine("Using Delegates:\n");

            printString psScreen = new printString(WriteToScreen);
            printString psFile = new printString(WriteToFile);

            SendString(psScreen);
            SendString(psFile);

            Console.ReadKey();
        }
    }
}
