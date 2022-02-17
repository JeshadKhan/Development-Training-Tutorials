﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _028__Reflection
{
    //a custom attribute BugFix to be assigned to a class and its members
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developer
        {
            get
            {
                return developer;
            }
        }

        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    //[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    //[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
}
