using myproject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.student
{
    public partial class leave_applying_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            myproject.classes.student_details student_leave_obj = new classes.student_details();
            student_leave_obj.Leave_student_name = leave_student_name.Text;
            student_leave_obj.Leave_student_class = leave_student_class.Text;
            student_leave_obj.Leave_start_date = leave_start_date.Text;
            student_leave_obj.Leave_end_date = leave_end_date.Text;
            student_leave_obj.Inseret_student_details();

        }

        protected void leave_end_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}