using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace myproject.classes
{
    public class staff
    {



        string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection con;
        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public void CloseConnection()
        {
            con.Close();
        }

        public void ExecuteQueries(string Query_)
        {
            // Whenever you want to execute a query, like an insert, update or delete
            //query then simply call this function 
            //using the object of a class and pass your query to the function
            OpenConection();
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }





        private string name_of_staff;
        private string staff_email_addres;
        private string mobile_number;
        private int staff_id;

        public string Name_of_staff
        {
            get
            {
                return name_of_staff;
            }

            set
            {
                name_of_staff = value;
            }
        }

        public string Staff_email_addres
        {
            get
            {
                return staff_email_addres;
            }

            set
            {
                staff_email_addres = value;
            }
        }

        public string Mobile_number
        {
            get
            {
                return mobile_number;
            }

            set
            {
                mobile_number = value;
            }
        }

        public int Staff_id
        {
            get
            {
                return staff_id;
            }

            set
            {
                staff_id = value;
            }
        }

        public DataTable ExecuteSelectQueries()
        {
            //  SqlCommand command = new SqlCommand("Select * from S_Registration where name=@zip", conn);
            //   command.Parameters.AddWithValue("@zip", "india");
            OpenConection();
            DataTable dtReg = new DataTable();
            SqlCommand command = new SqlCommand("Select * from studentregistration ", con);
            OpenConection();
            SqlDataAdapter da = new SqlDataAdapter(command);// this will query your database and return the result to your datatable

            da.Fill(dtReg);
            CloseConnection();
            return dtReg;


        }
     


   




    }
}