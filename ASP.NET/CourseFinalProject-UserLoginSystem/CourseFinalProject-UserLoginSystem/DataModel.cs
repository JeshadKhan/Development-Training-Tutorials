using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseFinalProject_UserLoginSystem
{
    public class DataModel
    {
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public char ActivationStatus { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}