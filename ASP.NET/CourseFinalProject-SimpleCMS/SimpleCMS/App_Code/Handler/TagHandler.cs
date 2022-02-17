using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.SessionState;
using WebMatrix.Data;

/// <summary>
/// Summary description for TagHandler
/// </summary>
public class TagHandler : IHttpHandler, IReadOnlySessionState
{
    public TagHandler()
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

        if (!WebUser.HasRole(UserRoles.Admin) && !WebUser.HasRole(UserRoles.Editor))
        {
            throw new HttpException(401, "You do not have permission to do this.");
        }

        var mode = context.Request.Form["mode"];
        var id = context.Request.Form["tagId"];
        var name = context.Request.Form["tagName"];
        var urlFriendlyName = context.Request.Form["tagUrlFriendlyName"];

        if (string.IsNullOrWhiteSpace(urlFriendlyName))
        {
            urlFriendlyName = CreateUrlFriendlyName(name);
        }

        if (mode == "edit")
        {
            EditTag(int.Parse(id), name, urlFriendlyName);
        }
        else if (mode == "new")
        {
            CreateTag(name, urlFriendlyName);
        }
        else if (mode == "delete")
        {
            DeleteTag(urlFriendlyName);
        }

        context.Response.Redirect("~/admin/tag/");
    }

    private static void CreateTag(string name, string urlFriendlyName)
    {
        var result = TagRepository.Get(urlFriendlyName);

        if (result != null)
        {
            throw new HttpException(409, "Url Friendly Name already exist.");
        }
        else
        {
            TagRepository.Add(name, urlFriendlyName);
        }
    }

    private static void EditTag(int id, string name, string urlFriendlyName)
    {
        var result = TagRepository.Get(id);

        if (result == null)
        {
            throw new HttpException(404, "Tag does not exist.");
        }
        else
        {
            TagRepository.Edit(id, name, urlFriendlyName);
        }
    }

    private static void DeleteTag(string urlFriendlyName)
    {
        TagRepository.Remove(urlFriendlyName);
    }

    private static string CreateUrlFriendlyName(string name)
    {
        name = name.ToLowerInvariant().Replace(" ", "-");
        name = Regex.Replace(name, @"[^0-9a-z]-", string.Empty);
        return name;
    }
}