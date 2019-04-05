using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using myproject.classes;

namespace myproject.module.staff
{
    public partial class RowFechingfromdbTable : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable addstudent = new DataTable();
                myproject.classes.staff sObj = new myproject.classes.staff();
                addstudent = sObj.ExecuteSelectQueries();
                if (addstudent.Rows.Count > 0)
                {
                    studentFetch.DataSource = addstudent;
                    studentFetch.DataBind();
                }
            }
        }




        protected void updateAttendance_Click(object sender, EventArgs e)
        {

             myproject.classes.student ajay = new classes.student();

            foreach (GridViewRow gvr in studentFetch.Rows)
            {
                if (((CheckBox)gvr.FindControl("chkAtt")).Checked == true)
                {

                 ajay.Rno    = Convert.ToInt32(((HiddenField)gvr.FindControl("hdnRNo")).Value);
                 ajay.MarkAbsent();
                    
                 }
            }

        }

        protected void studentFetch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



              
    
    
