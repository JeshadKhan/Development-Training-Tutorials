using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for PostRepository
/// </summary>
public class TagRepository
{
    private static readonly string connectionString = "QuaintDBConString";

    public TagRepository()
    {

    }

    public static dynamic Get(int id)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Tags WHERE Id = @0";
            return db.QuerySingle(sql, id);
        }
    }

    public static dynamic Get(string urlFriendlyName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Tags WHERE UrlFriendlyName = @0";
            return db.QuerySingle(sql, urlFriendlyName);
        }
    }

    public static IEnumerable<dynamic> GetAll(string where = null, string orderBy = null)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Tags";
            if (!string.IsNullOrEmpty(where))
            {
                sql += " WHERE " + where;
            }

            if (!string.IsNullOrEmpty(orderBy))
            {
                sql += " ORDER BY " + orderBy;
            }

            return db.Query(sql);
        }
    }

    public static void Add(string name, string urlFriendlyName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "INSERT INTO Tags (Name, UrlFriendlyName) VALUES (@0, @1)";
            db.Execute(sql, name, urlFriendlyName);
        }
    }

    public static void Edit(int id, string name, string urlFriendlyName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "UPDATE Tags SET Name = @0, UrlFriendlyName = @1 WHERE Id = @2";
            db.Execute(sql, name, urlFriendlyName, id);
        }
    }

    public static void Remove(string urlFriendlyName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "DELETE FROM Tags WHERE UrlFriendlyName = @0";
            db.Execute(sql, urlFriendlyName);
        }
    }
}