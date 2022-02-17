using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.Models;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DAL
{
    public class UserDAL
    {
        public bool SaveUser(SysUser user)
        {
            bool flag = false;
            DBPlayer db = new DBPlayer();

            try
            {
                db.cmdText = "INSERT INTO Users(Name, Email, Password) VALUES(@Name, @Email, @Password)";

                db.command.Parameters.AddWithValue("@Name", user.Name);
                db.command.Parameters.AddWithValue("@Email", user.Email);
                db.command.Parameters.AddWithValue("@Password", user.Password);

                db.Open();
                int rowsAffected = db.command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }

            return flag;
        }

        public bool IsUserExist(SysUser user)
        {
            bool flag = false;
            DBPlayer db = new DBPlayer();

            try
            {
                db.cmdText = "SELECT * FROM Users WHERE Email = @Email";
                db.command.Parameters.AddWithValue("@Email", user.Email);

                db.Open();
                SqlDataReader reader = db.command.ExecuteReader();

                if (reader.HasRows)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
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

            return flag;
        }

        public bool Login(SysUser user)
        {
            bool flag = false;
            DBPlayer db = new DBPlayer();

            try
            {
                db.cmdText = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                db.command.Parameters.AddWithValue("@Email", user.Email);
                db.command.Parameters.AddWithValue("@Password", user.Password);

                db.Open();
                SqlDataReader reader = db.command.ExecuteReader();

                if (reader.HasRows)
                {
                    flag = true;
                    HttpContext.Current.Session["User"] = user;
                }
                else
                {
                    flag = false;
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

            return flag;
        }
    }
}