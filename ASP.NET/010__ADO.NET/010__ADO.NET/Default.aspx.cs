using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _010__ADO.NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = CreateDataSet();
                gridViewStudent.DataSource = ds.Tables["Student"];
                gridViewStudent.DataBind();
            }
        }

        private DataSet CreateDataSet()
        {
            // creating a dataset object for tables
            DataSet ds = new DataSet();

            // creating the student table
            DataTable dt = CreateStudentTable();
            ds.Tables.Add(dt);
            return ds;
        }

        private DataTable CreateStudentTable()
        {
            DataTable dt = new DataTable("Student");

            // adding columns
            AddNewColumn(dt, "System.Int32", "StudentID");
            AddNewColumn(dt, "System.String", "StudentName");
            AddNewColumn(dt, "System.String", "StudentCity");

            // adding rows
            AddNewRow(dt, 1, "M H Kabir", "Kolkata");
            AddNewRow(dt, 2, "Shreya Sharma", "Delhi");
            AddNewRow(dt, 3, "Rini Mukherjee", "Hyderabad");
            AddNewRow(dt, 4, "Sunil Dubey", "Bikaner");
            AddNewRow(dt, 5, "Rajat Mishra", "Patna");

            return dt;
        }

        // making table columns
        private void AddNewColumn(DataTable table, string columnType, string columnName)
        {
            DataColumn column = table.Columns.Add(columnName, Type.GetType(columnType));
        }

        //adding data into the table
        private void AddNewRow(DataTable table, int id, string name, string city)
        {
            DataRow newRow = table.NewRow();
            newRow["StudentID"] = id;
            newRow["StudentName"] = name;
            newRow["StudentCity"] = city;
            table.Rows.Add(newRow);
        }
    }
}