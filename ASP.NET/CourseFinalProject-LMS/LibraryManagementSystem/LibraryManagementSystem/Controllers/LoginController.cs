using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(SysUser user)
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                if (userDAL.IsUserExist(user))
                {
                    if (userDAL.Login(user))
                    {
                        Response.Redirect("~/Employee/EmployeeList");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Email & password does not match.";
                        //Response.Redirect("~/Login/Login");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "User already exist.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message.ToString();
            }

            return View();
        }
    }
}