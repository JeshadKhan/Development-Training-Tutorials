using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _032__Events
{
    class Program
    {
        public static event EventHandler eHandler;

        public static void Event1()
        {
            Console.WriteLine("Event - 1");
        }

        public static void Event2()
        {
            Console.WriteLine("Event - 2");
        }

        public static void Event3()
        {
            Console.WriteLine("Event - 3");
        }
        


        static void Logger(string info)
        {
            Console.WriteLine(info);
        }



        static void Main(string[] args)
        {
            /* Event Firing */
            Console.WriteLine("Event Firing:\n");

            EventTest eT = new EventTest(5);
            eT.SetValue(7);
            eT.SetValue(9);

            Console.WriteLine("\n\n");



            /* Multi Event Firing */
            Console.WriteLine("Multi Event Firing:\n");

            // Add event handlers to Show event.
            eHandler += new EventHandler(Event1);
            eHandler += new EventHandler(Event2);
            eHandler += new EventHandler(Event3);
            eHandler += new EventHandler(Event3);

            // Invoke the event.
            eHandler.Invoke();
            
            Console.WriteLine("\n\n");



            /* Hot Water Boiler System */
            Console.WriteLine("Hot Water Boiler System:\n");

            BoilerInfoLogger filelog = new BoilerInfoLogger("boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            filelog.Close();

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
