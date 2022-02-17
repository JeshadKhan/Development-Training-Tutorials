using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _032__Events
{
    public delegate void EventHandler();

    class MultiEvent
    {
        public event EventHandler eHandler;
        void Event1()
        {
            Console.WriteLine("Event - 1");
        }

        public void Event2()
        {
            Console.WriteLine("Event - 2");
        }

        public void Event3()
        {
            Console.WriteLine("Event - 3");
        }
    }
}
