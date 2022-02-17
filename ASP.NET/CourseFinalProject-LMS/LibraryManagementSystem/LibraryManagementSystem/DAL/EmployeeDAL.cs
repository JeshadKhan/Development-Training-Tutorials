using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.Models;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DAL
{
    public class EmployeeDAL
    {
        public List<Department> GetDepartments()
        {
            List<Department> listOfDepartment = new List<Department>();
            DBPlayer db = new DBPlayer();

            try
            {
                db.cmdText = "SELECT * FROM HRM_DepartmentInfo";

                db.Open();
                SqlDataReader reader = db.command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Department department = new Department();
                        department.Code = reader["DepartmentCode"].ToString().Trim();
                        department.Name = reader["DepartmentName"].ToString().Trim();
                        listOfDepartment.Add(department);
                    }
                }

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }

            return listOfDepartment;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            DBPlayer db = new DBPlayer();

            try
            {
                db.cmdText = "SELECT * FROM HRM_EmployeeInfo";

                db.Open();
                SqlDataReader reader = db.command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.EmployeeName = reader["EmployeeName"].ToString().Trim();
                        employee.DepartmentName = reader["DepartmentName"].ToString().Trim();
                        employee.DepartmentCode = reader["DepartmentCode"].ToString().Trim();
                        listOfEmployee.Add(employee);
                    }
                }

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }

            return listOfEmployee;
        }
    }
}