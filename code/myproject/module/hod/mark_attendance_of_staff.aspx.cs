using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.hod
{
    public partial class mark_attendance_of_staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable addstaff = new DataTable();
                myproject.classes.HOD sObj = new myproject.classes.HOD();
                addstaff = sObj.staff_Fetch();
                if (addstaff.Rows.Count > 0)
                {
                    fetch_Staff_Attendance.DataSource = addstaff;
                    fetch_Staff_Attendance.DataBind();
                }
            }


        }

        protected void submit_Click(object sender, EventArgs e)
        {

            myproject.classes.HOD  staffobj = new classes.HOD();

            foreach (GridViewRow gvr in fetch_Staff_Attendance.Rows)
            {
                if (((CheckBox)gvr.FindControl("staff_attendance_checkbox")).Checked == true)
                {
                
                  staffobj.Rono = Convert.ToInt32(((HiddenField)gvr.FindControl("hidden_num")).Value);
                  staffobj.Mark_staff_Absent();

                }
            }
        }
    }
}