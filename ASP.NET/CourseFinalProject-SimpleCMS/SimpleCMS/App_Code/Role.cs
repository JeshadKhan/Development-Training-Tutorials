using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using WebMatrix.Data;

/// <summary>
/// Summary description for Role
/// </summary>
public class Role
{
    public Role()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private static WebPageRenderingBase Page
    {
        get { return WebPageContext.Current.Page; }
    }

    public static string Mode
    {
        get
        {
            if (Page.UrlData.Any())
            {
                return Page.UrlData[0].ToLower();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public static string Name
    {
        get
        {
            if (Mode != "new")
            {
                return Page.UrlData[1];
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public static dynamic Current
    {
        get
        {
            var result = RoleRepository.Get(Name);
            return result ?? CreateRoleObject();
        }
    }

    private static dynamic CreateRoleObject()
    {
        dynamic obj = new ExpandoObject();
        obj.Id = 0;
        obj.Name = string.Empty;

        return obj;
    }
}