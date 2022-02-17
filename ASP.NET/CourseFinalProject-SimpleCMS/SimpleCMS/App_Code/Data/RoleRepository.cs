using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Summary description for RoleRepository
/// </summary>
public class RoleRepository
{
    private static readonly string connectionString = "QuaintDBConString";

    public RoleRepository()
    {

    }

    public static dynamic Get(int id)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Roles WHERE Id = @0";
            return db.QuerySingle(sql, id);
        }
    }

    public static dynamic Get(string rolerName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Roles WHERE Name = @0";
            return db.QuerySingle(sql, rolerName);
        }
    }

    public static IEnumerable<dynamic> GetAll(string where = null, string orderBy = null)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Roles";
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

    public static void Add(string roleName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Roles WHERE Name = @0";
            var role = db.QuerySingle(sql, roleName);

            if (role!=null)
            {
                throw new Exception("Role already exist.");
            }

            sql = "INSERT INTO Roles (Name) VALUES (@0)";
            db.Execute(sql, roleName);
        }
    }

    public static void Edit(int id, string rolerName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "UPDATE Roles SET Name = @0 WHERE Id = @1";
            db.Execute(sql, rolerName, id);
        }
    }

    public static void Remove(string rolerName)
    {
        using (var db = Database.Open(connectionString))
        {
            var sql = "DELETE FROM Roles WHERE Name = @0";
            db.Execute(sql, rolerName);
        }
    }

    public static IEnumerable<dynamic> GetRolesForUser(int id)
    {      
        using (var db = Database.Open(connectionString))
        {
            var sql = "SELECT * FROM Roles r INNER JOIN UsersRolesMap m ON r.Id = m.RoleId WHERE m.UserId = @0";
            return db.Query(sql, id);
        }
    }
}