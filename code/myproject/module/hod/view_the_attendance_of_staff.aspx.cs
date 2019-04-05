using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.hod
{
    public partial class view_the_attendance_of_staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                DataTable fetch_attendance_of_staff = new DataTable();
                myproject.classes.HOD staffobj = new classes.HOD();
                fetch_attendance_of_staff = staffobj.view_staff_attendance();
                if (fetch_attendance_of_staff.Rows.Count > 0)
                {
                    staff_attendance.DataSource = fetch_attendance_of_staff;
                    staff_attendance.DataBind();
                }

            }

        }
    }
}