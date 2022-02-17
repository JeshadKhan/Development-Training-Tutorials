using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Models
{
    public class SysUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static bool IsAuthenticated()
        {
            SysUser user = (SysUser)HttpContext.Current.Session["User"];

            if (user == null)
            {
                return false;
            }
            else
            {
                //UserDAL userDAL=new UserDAL();
                //return userDAL.IsUserExist(user);
                return true;
            }
        }
    }
}