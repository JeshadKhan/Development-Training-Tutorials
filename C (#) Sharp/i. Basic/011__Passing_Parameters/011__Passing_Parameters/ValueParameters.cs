using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011__Passing_Parameters
{
    class ValueParameters
    {
        public void Swap(int x, int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
    }
}
