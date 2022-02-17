using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _028__Reflection
{
    [AttributeUsage(AttributeTargets.All)]
    class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic   // Topic is a named parameter
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }

        public HelpAttribute(string url)   // url is a positional parameter
        {
            this.Url = url;
        }

        private string topic;
    }
}
