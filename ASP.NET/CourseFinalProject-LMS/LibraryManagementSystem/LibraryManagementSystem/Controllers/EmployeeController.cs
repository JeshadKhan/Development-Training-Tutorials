using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeList()
        {
            try
            {
                if (!SysUser.IsAuthenticated())
                {
                    Response.Redirect("~/Login/Login");
                }

                EmployeeDAL employeeDAL = new EmployeeDAL();
                List<Department> listOfDepartment = employeeDAL.GetDepartments();
                ViewBag.Departments = listOfDepartment;
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message.ToString();
            }

            return View();
        }

        public JsonResult GetEmployeeByDepartmentId(string departmentId)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var employees = employeeDAL.GetEmployees();
            var studentList = employees.Where(e => e.DepartmentCode == departmentId).ToList();
            return Json(studentList, JsonRequestBehavior.AllowGet);
        }
    }
}