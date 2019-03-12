using myApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace attendancemanagament.registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private object password;
        private object username;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            obj.Username = uname.Text;
            obj.Password = passwd.Text;
            obj.InsertStudent();
        }
    }
}