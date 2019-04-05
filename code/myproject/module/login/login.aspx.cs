using myproject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;

namespace myproject.module.login
{
    public partial class login : System.Web.UI.Page
    {

        myproject.classes.student db;
        SqlConnection con;
        private object username;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new myproject.classes.student();
            con = new SqlConnection("Data Source=DESKTOP-AE8GEQ9;Initial Catalog=registration;User ID=sa;Password=sjcet");
            con.Open();

        }





        protected void submit_Click(object sender, EventArgs e)
        {


            myproject.classes.student objStd = new classes.student();
            //objStd.Username = username.Text;
            objStd.Password = password.Text;
            objStd.Section = section.Text;



            int res = objStd.CheckLogin();

            if (res == 1)
            {
                if (section.Text == "student")
                    Response.Redirect("~/module/admin/admin.aspx");
                //   else if (section.Text == "admin")
                //     Response.Redirect("admin.aspx");

            }
            else
            {

            }






        }


    }

    
}