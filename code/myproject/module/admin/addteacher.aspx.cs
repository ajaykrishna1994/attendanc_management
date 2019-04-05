
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myproject.classes;
namespace myproject.module.admin
{
    public partial class addteacher : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void staffsubmit_Click(object sender, EventArgs e)
        {
            myproject.classes.student adobj = new classes.student();
            adobj.Staffname = staffname.Text;
            adobj.Staff_id = staff_id.Text;
            adobj.Staffemailaddress = emailaddress.Text;
            adobj.Staffmobilenumber = mobilenumber.Text;
            adobj.Staffusername= username.Text;
            adobj.Staffpassword = password.Text;
            adobj.Insertstaff();



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void staffname0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}