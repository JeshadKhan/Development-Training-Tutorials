using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace _033__Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList */
            Console.WriteLine("ArrayList:\n");

            ArrayList al = new ArrayList();

            // Set data in ArrayList
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nSorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n");



            /* Hashtable */
            Console.WriteLine("Hashtable:\n");

            Hashtable ht = new Hashtable();

            // Set Hashtable data with key-value pair
            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            // Get Hashtable data with keys
            ICollection keys = ht.Keys;

            foreach (string key in keys)
            {
                // Values are not set or get sequentially
                Console.WriteLine("Keys: " + key + "\tValues: " + ht[key]);
            }

            Console.WriteLine("\n\n");



            /* SortedList */
            Console.WriteLine("SortedList:\n");

            SortedList sl = new SortedList();

            // Set SortedList data with key-value pair
            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }

            // Get SortedList data with keys
            ICollection slKeys = sl.Keys;

            foreach (string slkey in slKeys)
            {
                // Values are set or get sequentially
                Console.WriteLine("Keys: " + slkey + "\tValues: " + sl[slkey]);
            }

            Console.WriteLine("\n\n");



            /* Stack */
            Console.WriteLine("Stack (last-in, first out - lifo):\n");

            Stack st = new Stack();

            // Set Stack data with the method lifo (last-in, first out)
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.Write("Current stack: ");
            foreach (char s in st)
            {
                Console.Write(s + " ");
            }

            // Pushing data to the Stack
            st.Push('V');
            st.Push('H');

            Console.WriteLine("\nThe next poppable value in stack (return last settled value): {0}", st.Peek());

            Console.Write("Current stack: ");
            foreach (char s in st)
            {
                Console.Write(s + " ");
            }

            // Removing values from the Stack
            st.Pop();
            st.Pop();
            st.Pop();

            Console.Write("\nAfter removing from the stack: ");
            foreach (char s in st)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n\n\n");



            /* Queue */
            Console.WriteLine("Queue (first-in, first out - fifo):\n");

            Queue q = new Queue();

            // Set Queue data with the method fifo (first-in, first out)
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.Write("Current queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }

            // Adding more data in Queue
            q.Enqueue('V');
            q.Enqueue('H');

            Console.Write("\nAfter adding more data in queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }

            // Removing some values from the Queue
            char ch = (char)q.Dequeue();
            Console.WriteLine("\nThe removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.Write("Current queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine("\n\n\n");



            /* BitArray */
            Console.WriteLine("BitArray:\n");

            //creating two  bit arrays of size 8
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };

            //storing the values 60, and 13 into the bit arrays
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            //content of ba1
            Console.WriteLine("Bit array ba1: 60");

            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6} ", ba1[i]);
            }

            //content of ba2
            Console.WriteLine("\nBit array ba2: 13");

            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6} ", ba2[i]);
            }

            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }

            ba3 = ba1.Or(ba2);

            //content of ba3
            Console.WriteLine("\nBit array ba3 after OR operation: 61");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
