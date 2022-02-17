using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _032__Events
{
    class EventTest
    {
        private int value;
        private delegate void NumManipulationHandler();
        private event NumManipulationHandler NumChange;

        public EventTest(int n)
        {
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value!=n)
            {
                value = n;
                OnNumChange();
            }
        }

        private void OnNumChange()
        {
            if (NumChange!=null)
            {
                NumChange();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }
    }
}
