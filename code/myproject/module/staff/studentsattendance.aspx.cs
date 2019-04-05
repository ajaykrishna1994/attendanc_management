using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace myproject.module.staff
{
    public partial class studentsattendance : System.Web.UI.Page
    {
        public static DataTable DataSource { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Country"), new DataColumn("Salary") });
                dt.Rows.Add(1, "John Hammond", "United States", 70000);
                dt.Rows.Add(2, "Mudassar Khan", "India", 40000);
                dt.Rows.Add(3, "Suzanne Mathews", "France", 30000);
                dt.Rows.Add(4, "Robert Schidner", "Russia", 50000);
                rptCustomers.DataSource = dt;
                rptCustomers.DataBind();
            }
        }

        protected void rptCustomers_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}