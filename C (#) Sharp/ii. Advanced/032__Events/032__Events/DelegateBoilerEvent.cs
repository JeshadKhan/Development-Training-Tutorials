using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _032__Events
{
    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);

        public event BoilerLogHandler BoilerEventLog;

        public void LogProcess()
        {
            string remarks = "O. K";
            Boiler b = new Boiler(100, 12);
            int t = b.GetTemp();
            int p = b.GetPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            OnBoilerEventLog("Logging Info:");
            OnBoilerEventLog("Temparature: " + t + "\tPressure: " + p);
            OnBoilerEventLog("Message: " + remarks);
        }

        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }
}
