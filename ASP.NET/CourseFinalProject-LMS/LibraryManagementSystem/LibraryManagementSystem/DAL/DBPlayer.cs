using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LibraryManagementSystem.DAL
{
    public class DBPlayer
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;
        private SqlConnection SqlConnection;
        public SqlCommand command;
        public string cmdText { get; set; }

        public DBPlayer()
        {
            SqlConnection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Parameters.Clear();
        }

        public void Open()
        {
            this.command.CommandText = this.cmdText;
            this.command.Connection = this.SqlConnection;            
            this.SqlConnection.Open();
        }

        public void Close()
        {
            this.SqlConnection.Close();
        }
    }
}