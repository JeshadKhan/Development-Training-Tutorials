using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace _037__Multithreading
{
    class Program
    {
        // Creating Threads
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts - Creating Threads");
        }

        // Managing Threads
        public static void CallToChildThread2()
        {
            Console.WriteLine("Child thread starts - Managing Threads");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);

            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        // Destroying Threads
        public static void CallToChildThread3()
        {
            try
            {
                Console.WriteLine("Child thread starts - Destroying Threads");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");

            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        // Main Method
        static void Main(string[] args)
        {
            /* The Main Thread */
            Console.WriteLine("The Main Thread:\n");

            Thread thread = Thread.CurrentThread;
            thread.Name = "MainThread";

            Console.WriteLine("This is " + thread.Name);
            Console.WriteLine("\n\n");



            /* Creating Threads */
            Console.WriteLine("Creating Threads:\n");

            ThreadStart ts = new ThreadStart(CallToChildThread);

            Console.WriteLine("In Main: Creating the Child thread");

            Thread th = new Thread(ts);
            th.Start();
            Console.WriteLine("\n\n");



            /* Managing Threads */
            Console.WriteLine("Managing Threads:\n");

            ThreadStart tsNew = new ThreadStart(CallToChildThread2);

            Console.WriteLine("In Main: Creating the Child thread");

            Thread thNew = new Thread(tsNew);
            thNew.Start();
            Console.WriteLine("\n\n");



            /* Destroying Threads */
            Console.WriteLine("Destroying Threads:\n");

            ThreadStart tstart = new ThreadStart(CallToChildThread3);

            Console.WriteLine("In Main: Creating the Child thread");

            Thread thd = new Thread(tstart);
            thd.Start();

            // stop the main thread for some time (where, 1000 = 1 sec)
            Thread.Sleep(2000);

            // now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");
            thd.Abort();
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
