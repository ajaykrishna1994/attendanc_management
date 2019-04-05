using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.admin
{
    public partial class admin : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Redirect("addstudent.aspx?id=#seconframe");
            }
        }

        protected void submit_Click1(object sender, EventArgs e)
        {
            Response.Redirect("addteacher.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Response.Redirect("addstudent.aspx");
        }
    }
}