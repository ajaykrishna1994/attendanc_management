using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.hod
{
    public partial class viewAttendanceOfstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                DataTable View_Absent_Students = new DataTable();
                myproject.classes.HOD View_Absent_Students_obj = new classes.HOD();
                View_Absent_Students = View_Absent_Students_obj.Execute_student_absent_Queries();

                if (View_Absent_Students.Rows.Count > 0)
                {
                    id_of_Absent_Students.DataSource = View_Absent_Students;
                    id_of_Absent_Students.DataBind();
                }

            }



        }
    }
}