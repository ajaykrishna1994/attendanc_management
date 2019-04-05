using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myproject.classes;

namespace myproject
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Name = sname.Text;
            obj.Stream = stream.Text;
            obj.Username = username.Text;
            obj.Password = password.Text;
            obj.InsertStudent();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

    





        }
    }
}