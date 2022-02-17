using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _036__Unsafe_Codes
{
    class TestPointer
    {
        public unsafe void Swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
    }
}
