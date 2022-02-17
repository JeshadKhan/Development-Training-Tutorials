using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace _026__File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* File Input Output (I/O) */
            Console.WriteLine("File Input Output (I/O):\n");
            FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < 20; i++)
            {
                f.WriteByte((byte)i);
            }

            f.Position = 0;

            for (int j = 0; j < 20; j++)
            {
                Console.Write(f.ReadByte() + " ");
            }

            f.Close();
            Console.WriteLine("\n\n");



            /* Stream Reader */
            Console.WriteLine("Stream Reader:\n");
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("sample.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n");



            /* Stream Writer */
            Console.WriteLine("Stream Writer:\n");
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string lineNew = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((lineNew = sr.ReadLine()) != null)
                {
                    Console.WriteLine(lineNew);
                }
            }



            /* Windows File System */
            Console.WriteLine("Windows File System:\n");
            // creating a DirectoryInfo object
            DirectoryInfo di = new DirectoryInfo(@"C:\Windows");
            // get total file size of the Windows folder files
            FileInfo[] fi = di.GetFiles();
            double size = 0;

            foreach (FileInfo file in fi)
            {
                size = size + file.Length;
            }

            Console.WriteLine("File Size: {0}", size);
            Console.ReadKey();
        }
    }
}
