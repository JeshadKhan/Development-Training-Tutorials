using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for PostRepository
/// </summary>
public class PostRepository
{
    private static readonly string connectionString = "QuaintDBConString";

    public PostRepository()
    {

    }

    public static dynamic Get(int id)
    {
        var sql = "SELECT p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId WHERE p.Id = @0";
        var results = DoGet(sql, id);
        return results.Any() ? results.First() : null;
    }

    public static dynamic Get(string slug)
    {
        var sql = "SELECT p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId WHERE Slug = @0";
        var results = DoGet(sql, slug);
        return results.Any() ? results.First() : null;
    }

    private static IEnumerable<dynamic> DoGet(string sql, params object[] values)
    {
        using (var db = Database.Open(connectionString))
        {
            var posts = new List<dynamic>();
            var results = db.Query(sql, values);

            foreach (dynamic result in results)
            {
                dynamic post = posts.SingleOrDefault(p => p.Id == result.Id);

                if (post == null)
                {
                    post = CreatePostObject(result);
                    posts.Add(post);
                }

                if (result.TagId == null)
                {
                    continue;
                }
                else
                {
                    dynamic tag = new ExpandoObject();
                    tag.Id = result.TagId;
                    tag.Name = result.TagName;
                    tag.UrlFriendlyName = result.TagUrlFriendlyName;
                    post.Tags.Add(tag);
                }
            }

            return posts.ToArray();
        }
    }

    public static IEnumerable<dynamic> GetAll(string orderBy = null)
    {
        //var sql = "SELECT * FROM Posts";
        var sql = "SELECT p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId";

        if (!string.IsNullOrEmpty(orderBy))
        {
            sql += " ORDER BY " + orderBy;
        }

        return DoGet(sql);
    }

    public static IEnumerable<dynamic> GetPublishedPosts(int count = 0)
    {
        var topClause = count > 0 ? string.Format(" TOP {0}", count) : string.Empty;

        //var sql = string.Format("SELECT {0} p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName, u.UserName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId INNER JOIN Users u ON u.Id = p.AuthorId WHERE DatePublished IS NOT NULL AND DatePublished < GETDATE() ORDER BY DatePublished DESC", topClause);
        var sql = string.Format("SELECT {0} p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName, u.UserName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId INNER JOIN Users u ON u.Id = p.AuthorId WHERE DatePublished IS NOT NULL ORDER BY DatePublished DESC", topClause);
        return DoGet(sql);
    }

    public static IEnumerable<dynamic> GetPublishedPostsByTag(string urlFriendlyName)
    {
        //var sql = "SELECT p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName, u.UserName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId INNER JOIN Users u ON u.Id = p.AuthorId WHERE DatePublished IS NOT NULL AND DatePublished < GETDATE() AND t.UrlFriendlyName = @0 ORDER BY DatePublished DESC";
        var sql = "SELECT p.*, t.Id AS TagId, t.Name AS TagName, t.UrlFriendlyName AS TagUrlFriendlyName, u.UserName FROM Posts p LEFT JOIN PostsTagsMap m ON p.Id = m.PostId LEFT JOIN Tags t ON t.Id = m.TagId INNER JOIN Users u ON u.Id = p.AuthorId WHERE DatePublished IS NOT NULL AND t.UrlFriendlyName = @0 ORDER BY DatePublished DESC";
        return DoGet(sql, urlFriendlyName);
    }

    public static void Add(string title, string content, string slug, DateTime? datePublished, int authorId, IEnumerable<int> tags)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "INSERT INTO Posts (Title, Content, Slug, DatePublished, AuthorId) VALUES (@0, @1, @2, @3, @4)";
            db.Execute(sql, title, content, slug, datePublished, authorId);

            var post = db.QuerySingle("SELECT * FROM Posts WHERE Slug = @0", slug);
            AddTags(post.Id, tags, db);
        }
    }

    public static void Edit(int id, string title, string content, string slug, DateTime? datePublished, int authorId, IEnumerable<int> tags)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "UPDATE Posts SET Title = @0, Content = @1, Slug = @2, DatePublished = @3, AuthorId = @4 WHERE Id = @5";
            db.Execute(sql, title, content, slug, datePublished, authorId, id);

            DeleteTags(id, db);
            AddTags(id, tags, db);
        }
    }

    public static void Remove(string slug)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Posts WHERE Slug = @0";
            var post = db.QuerySingle(sql, slug);

            if (post == null)
            {
                return;
            }

            DeleteTags(post.Id, db);

            sql = "DELETE FROM Posts WHERE Id = @0";
            db.Execute(sql, post.Id);
        }
    }

    private static void AddTags(int postId, IEnumerable<int> tags, Database db)
    {
        if (!tags.Any())
        {
            return;
        }

        var sql = "INSERT INTO PostsTagsMap (PostId, TagId) VALUES (@0, @1)";
        //var count = 1;
        //var valueSets = tags.Select(t => string.Format("@0, @{0}", count++));
        //sql += string.Join(", ", valueSets);
        //db.Execute(sql, postId, tags.ToArray());
        foreach (var tag in tags)
        {
            db.Execute(sql, postId, tag);
        }
    }

    private static void DeleteTags(int id, Database db)
    {
        var sql = "DELETE FROM PostsTagsMap WHERE PostId = @0";
        db.Execute(sql, id);
    }

    private static dynamic CreatePostObject(dynamic obj)
    {
        dynamic post = new ExpandoObject();
        post.Id = obj.Id;
        post.Title = obj.Title;
        post.Content = obj.Content;
        post.DateCreated = obj.DateCreated;
        post.DatePublished = obj.DatePublished;
        post.Slug = obj.Slug;
        post.AuthorId = obj.AuthorId;
        post.Tags = new List<dynamic>();
        //post.UserName = obj.UserName;

        return post;
    }
}