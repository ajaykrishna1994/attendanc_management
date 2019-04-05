using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.student
{
    public partial class student_viewing_attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                DataTable student_fetch_attendance = new DataTable();
                myproject.classes.student_details student_obj = new myproject.classes.student_details();
                student_fetch_attendance = student_obj.student_can_view_attendance_query();
                if(student_fetch_attendance.Rows.Count > 0)
                {

                    student_can_view_attendance_grid.DataSource = student_fetch_attendance;
                    student_can_view_attendance_grid.DataBind();


                }
            }
        }
    }
}