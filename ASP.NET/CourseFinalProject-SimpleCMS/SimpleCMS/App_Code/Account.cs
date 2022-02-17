using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using WebMatrix.Data;

/// <summary>
/// Summary description for Account
/// </summary>
public class Account
{
    public Account()
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

    public static string UserName
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
            var result = AccountRepository.Get(UserName);
            return result ?? CreateAccountObject();
        }
    }

    private static dynamic CreateAccountObject()
    {
        dynamic obj = new ExpandoObject();
        obj.Id = 0;
        obj.UserName = string.Empty;
        obj.Password = string.Empty;
        obj.Email = string.Empty;

        return obj;
    }
}