using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011__Passing_Parameters
{
    class OutputParameters
    {
        public void GetValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
}
