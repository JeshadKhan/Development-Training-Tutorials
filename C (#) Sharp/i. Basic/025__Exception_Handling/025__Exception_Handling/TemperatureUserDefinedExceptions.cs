using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _025__Exception_Handling
{
    class TemperatureUserDefinedExceptions
    {
        int temperature = 0;

        public void ShowTemperature()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}
