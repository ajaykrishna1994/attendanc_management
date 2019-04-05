using myproject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject.module.admin
{
    public partial class addstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            myproject.classes.student studobj = new classes.student();

            studobj.Studentrollno =rollno.Text;
            studobj.Studentname = studentname.Text;
            studobj.Studentemail =studentemail.Text;
            studobj.Studentmobilenumber = mobilenumber.Text;
            studobj.Studentusername =username.Text;
            studobj.Studentpassword = password.Text;
            studobj.Section =section.Text;
            studobj.Insertstdn();



        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void rollno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}