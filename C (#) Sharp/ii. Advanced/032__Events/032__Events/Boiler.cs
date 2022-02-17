using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _032__Events
{
    class Boiler
    {
        private int temp;
        private int pressure;

        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }

        public int GetTemp()
        {
            return temp;
        }

        public int GetPressure()
        {
            return pressure;
        }
    }
}
