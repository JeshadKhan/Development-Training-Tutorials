using LibraryManagementSystem.Models;
using LibraryManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(SysUser user)
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                if (!userDAL.IsUserExist(user))
                {
                    if (userDAL.SaveUser(user))
                    {
                        ViewBag.ErrorMessage = "User saved successfully.";
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "User saved failed.";
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