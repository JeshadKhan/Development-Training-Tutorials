using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.SessionState;
using WebMatrix.Data;

/// <summary>
/// Summary description for AccountHandler
/// </summary>
public class AccountHandler : IHttpHandler, IReadOnlySessionState
{
    public AccountHandler()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool IsReusable
    {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context)
    {
        AntiForgery.Validate();

        if (!WebUser.IsAuthenticated)
        {
            throw new HttpException(401, "You must login to this.");
        }

        if (!WebUser.HasRole(UserRoles.Admin))
        {
            throw new HttpException(401, "You do not have permission to do this.");
        }

        var mode = context.Request.Form["mode"];
        var id = context.Request.Form["accountId"];
        var name = context.Request.Form["accountName"];
        var password1 = context.Request.Form["accountPassword1"];
        var password2 = context.Request.Form["accountPassword2"];
        var email = context.Request.Form["accountEmail"];
        var userRoles = context.Request.Form["accountRoles"];
        var roles = userRoles.Split(',').Select(v => Convert.ToInt32(v));
                
        if (mode == "delete")
        {
            DeleteUser(name);
        }
        else
        {
            if (password1!=password2)
            {
                throw new Exception("Password do not match.");
            }

            if (string.IsNullOrEmpty(email.Trim()))
            {
                throw new Exception("Email can not blank.");
            }

            if (string.IsNullOrEmpty(name.Trim()))
            {
                throw new Exception("Name can not blank.");
            }

            if (mode == "edit")
            {
                EditUser(int.Parse(id), name, password1, email, roles);
            }
            else if (mode == "new")
            {
                CreateUser(name, password1, email, roles);
            }
        }

        context.Response.Redirect("~/admin/account/");
    }

    private static void CreateUser(string name, string password, string email, IEnumerable<int> roles)
    {
        var result = AccountRepository.Get(name);

        if (result != null)
        {
            throw new HttpException(409, "User already exist.");
        }
        else
        {
            AccountRepository.Add(name, password, email, roles);
        }
    }

    private static void EditUser(int id, string name, string password, string email, IEnumerable<int> roles)
    {
        var result = AccountRepository.Get(id);

        if (result == null)
        {
            throw new HttpException(404, "User does not exist.");
        }
        else
        {
            var updatePassword = result.Password;

            if (!string.IsNullOrEmpty(password.Trim()))
            {
                updatePassword = password;
            }

            AccountRepository.Edit(id, name, updatePassword, email, roles);
        }
    }

    private static void DeleteUser(string name)
    {
        AccountRepository.Remove(name);
    }
}