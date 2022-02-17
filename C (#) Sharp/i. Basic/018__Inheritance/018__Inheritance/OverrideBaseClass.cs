using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018__Inheritance
{
    // Override Base Class
    class OverrideBaseClass : Rectangle
    {
        private int cost;

        public OverrideBaseClass(int w, int h) : base(w, h) { }

        public int GetCost()
        {
            cost = GetArea() * 80;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Area cost is: {0}", this.GetCost());
        }
    }
}
