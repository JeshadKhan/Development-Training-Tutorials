using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.SessionState;
using WebMatrix.Data;

/// <summary>
/// Summary description for PostHandler
/// </summary>
public class PostHandler : IHttpHandler, IReadOnlySessionState
{
    public PostHandler()
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
        if (!WebUser.IsAuthenticated)
        {
            throw new HttpException(401, "You must login to this.");
        }

        if (!WebUser.HasRole(UserRoles.Admin) && !WebUser.HasRole(UserRoles.Editor) && !WebUser.HasRole(UserRoles.Author))
        {
            throw new HttpException(401, "You do not have permission to do this.");
        }

        var mode = context.Request.Form["mode"];
        var id = context.Request.Form["postId"];
        var authorId = context.Request.Form["postAuthorId"];
        var title = context.Request.Form["postTitle"];
        var content = context.Request.Form["postContent"];
        var slug = context.Request.Form["postSlug"];
        var datePublished = context.Request.Form["postDatePublished"];
        var postTags = context.Request.Form["postTags"];
        IEnumerable<int> tags = new int[] { };

        if (!string.IsNullOrEmpty(postTags))
        {
            tags = postTags.Split(',').Select(v => Convert.ToInt32(v));
        }

        if ((mode == "edit" || mode == "delete") && WebUser.HasRole(UserRoles.Author))
        {
            if (WebUser.UserId != Convert.ToInt32(authorId))
            {
                throw new HttpException(401, "You do not have permission to do this.");
            }
        }

        if (string.IsNullOrWhiteSpace(slug))
        {
            slug = CreateSlug(title);
        }

        if (mode == "edit")
        {
            EditPost(int.Parse(id), title, content, slug, datePublished, Convert.ToInt32(authorId), tags);
        }
        else if (mode == "new")
        {
            CreatePost(title, content, slug, datePublished, WebUser.UserId, tags);
        }
        else if (mode == "delete")
        {
            DeletePost(slug);
        }

        context.Response.Redirect("~/admin/post/");
    }

    private static void CreatePost(string title, string content, string slug, string datePublished, int authorId, IEnumerable<int> tags)
    {
        var result = PostRepository.Get(slug);
        DateTime? datePublishedParsed = null;

        if (result != null)
        {
            throw new HttpException(409, "Slug already exist.");
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(datePublished))
            {
                datePublishedParsed = DateTime.Parse(datePublished);
            }

            PostRepository.Add(title, content, slug, datePublishedParsed, authorId, tags);
        }
    }

    private static void EditPost(int id, string title, string content, string slug, string datePublished, int authorId, IEnumerable<int> tags)
    {
        var result = PostRepository.Get(id);
        DateTime? datePublishedParsed = null;

        if (result == null)
        {
            throw new HttpException(404, "Post does not exist.");
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(datePublished))
            {
                datePublishedParsed = DateTime.Parse(datePublished);
            }

            PostRepository.Edit(id, title, content, slug, datePublishedParsed, authorId, tags);
        }
    }

    private static void DeletePost(string slug)
    {
        PostRepository.Remove(slug);
    }

    private static string CreateSlug(string title)
    {
        title = title.ToLowerInvariant().Replace(" ", "-");
        title = Regex.Replace(title, @"[^0-9a-z]-", string.Empty);
        return title;
    }
}