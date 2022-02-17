using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using WebMatrix.Data;

/// <summary>
/// Summary description for AccountRepository
/// </summary>
public class AccountRepository
{
    private static readonly string connectionString = "QuaintDBConString";

    public AccountRepository()
    {

    }

    public static dynamic Get(int id)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Users WHERE Id = @0";
            return db.QuerySingle(sql, id);
        }
    }

    public static dynamic Get(string userName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Users WHERE UserName = @0";
            return db.QuerySingle(sql, userName);
        }
    }

    public static IEnumerable<dynamic> GetAll(string where = null, string orderBy = null)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Users";
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

    public static void Add(string userName, string password, string email, IEnumerable<int> roles)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Users WHERE UserName = @0";
            var user = db.QuerySingle(sql, userName);

            if (user!=null)
            {
                throw new Exception("User already exist.");
            }

            sql = "INSERT INTO Users (UserName, Password, Email) VALUES (@0, @1, @2)";
            db.Execute(sql, userName, Crypto.HashPassword(password), email);

            var role = db.QuerySingle("SELECT * FROM Users WHERE UserName = @0", userName);
            AddRoles(role.Id, roles, db);
        }
    }

    public static void Edit(int id, string userName, string password, string email, IEnumerable<int> roles)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "UPDATE Users SET UserName = @0, Password = @1, Email = @2 WHERE Id = @3";
            db.Execute(sql, userName, Crypto.HashPassword(password), email, id);

            DeleteRoles(id, db);
            AddRoles(id, roles, db);
        }
    }

    public static void Remove(string userName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "DELETE FROM Users WHERE UserName = @0";
            db.Execute(sql, userName);
        }
    }

    private static void AddRoles(int userId, IEnumerable<int> roles, Database db)
    {
        if (!roles.Any())
        {
            return;
        }

        var sql = "INSERT INTO UsersRolesMap (UserId, RoleId) VALUES (@0, @1)";

        foreach (var role in roles)
        {
            db.Execute(sql, userId, role);
        }
    }

    private static void DeleteRoles(int userId, Database db)
    {
        var sql = "DELETE FROM UsersRolesMap WHERE UserId = @0";
        db.Execute(sql, userId);
    }
}