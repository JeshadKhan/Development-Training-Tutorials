using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Logout()
        {
            try
            {
                Session.Clear();
                Response.Redirect("~/Login/Login");
            }
            catch (Exception)
            {
                
                throw;
            }

            return View();
        }
    }
}