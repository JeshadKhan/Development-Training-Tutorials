using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.SessionState;

/// <summary>
/// Summary description for WebUser
/// </summary>
public class WebUser
{
    public WebUser()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private static HttpSessionState Session
    {
        get { return HttpContext.Current.Session; }
    }

    public static bool HasRole(string roleName)
    {
        var roles = GetRolesForUser();
        return roles.Contains(roleName);
    }

    public static IEnumerable<string> GetRolesForUser()
    {
        return GetRolesForUser(WebUser.UserId);
    }

    public static IEnumerable<string> GetRolesForUser(int accountId)
    {
        return RoleRepository.GetRolesForUser(accountId).Select(r => (string)r.Name);
    }

    public static bool Authenticate(string username, string password)
    {
        var user = AccountRepository.Get(username);

        if (user == null)
        {
            return false;
        }

        return Crypto.VerifyHashedPassword((string)user.Password, password);
    }

    public static void Login(string username, string password)
    {
        var user = AccountRepository.Get(username);

        if (user == null)
        {
            return;
        }

        SetupSession(user);
    }

    private static void SetupSession(dynamic user)
    {
        Session["UserId"] = (int)user.Id;
        Session["UserName"] = (string)user.UserName;
        Session["Email"] = (string)user.Email;
    }

    public static bool AuthenticateAndLogin(string username, string password)
    {
        var verified = Authenticate(username, password);

        if (!verified)
        {
            return false;
        }
        else
        {
            Login(username, password);
            return true;
        }
    }

    public static int UserId
    {
        get
        {
            var value = Session["UserId"];

            if (value == null)
            {
                return -1;
            }
            else
            {
                return (int)value;
            }
        }
    }

    public static string UserName
    {
        get
        {
            var value = Session["UserName"];

            if (value == null)
            {
                return string.Empty;
            }
            else
            {
                return (string)value;
            }
        }
    }

    public static string Email
    {
        get
        {
            var value = Session["Email"];

            if (value == null)
            {
                return string.Empty;
            }
            else
            {
                return (string)value;
            }
        }
    }

    public static bool IsAuthenticated
    {
        get
        {
            return !string.IsNullOrEmpty(UserName);
        }
    }
}