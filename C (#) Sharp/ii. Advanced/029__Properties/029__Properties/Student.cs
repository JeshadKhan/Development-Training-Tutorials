using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _029__Properties
{
    class Student
    {
        private string code = "N/A";
        private string name = "Unknown";
        private int age = 0;

        // Declare a "Code" property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a "Name" property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a "Age" property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
}
