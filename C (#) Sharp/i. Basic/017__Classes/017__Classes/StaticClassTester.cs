using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _017__Classes
{
    class StaticClassTester
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int getNum()
        {
            return num;
        }

        public static int getNumStatic()
        {
            return num;
        }
    }
}
