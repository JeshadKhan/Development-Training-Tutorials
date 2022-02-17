using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _025__Exception_Handling
{
    class TempIsZeroException:ApplicationException
    {
        public TempIsZeroException(string message):base(message)
        {}
    }
}
