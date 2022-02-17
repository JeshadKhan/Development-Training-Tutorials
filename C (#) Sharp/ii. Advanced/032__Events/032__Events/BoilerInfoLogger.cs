using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _032__Events
{
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;

        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }

        public void Logger(string info)
        {
            sw.WriteLine(info);
        }

        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }
}
