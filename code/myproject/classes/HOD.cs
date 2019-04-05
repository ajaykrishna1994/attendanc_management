using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace myproject.classes
{
    public class HOD
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


        private int rono;
        private string staff_name;
        private string staff_email_address;
        private string staff_mobile_number;

        public int Rono
        {
            get
            {
                return rono;
            }

            set
            {
                rono = value;
            }
        }

        public string Staff_name
        {
            get
            {
                return staff_name;
            }

            set
            {
                staff_name = value;
            }
        }

        public string Staff_email_address
        {
            get
            {
                return staff_email_address;
            }

            set
            {
                staff_email_address = value;
            }
        }

        public string Staff_mobile_number
        {
            get
            {
                return staff_mobile_number;
            }

            set
            {
                staff_mobile_number = value;
            }
        }

        public DataTable view_staff_attendance()
        {

            //  SqlCommand command = new SqlCommand("Select * from S_Registration where name=@zip", conn);
            //   command.Parameters.AddWithValue("@zip", "india");
            OpenConection();
            DataTable dtReg = new System.Data.DataTable();
            SqlCommand command = new SqlCommand("Select staffname,staffemailaddress,staffmobilenumber from addstaff ", con);
            OpenConection();
            SqlDataAdapter da = new SqlDataAdapter(command);// this will query your database and return the result to your datatable

            da.Fill(dtReg);
            CloseConnection();
            return dtReg;

        }





        public DataTable staff_Fetch()
        {

            //  SqlCommand command = new SqlCommand("Select * from S_Registration where name=@zip", conn);
            //   command.Parameters.AddWithValue("@zip", "india");
            OpenConection();
            DataTable dtReg = new System.Data.DataTable();
            SqlCommand command = new SqlCommand("Select staffid,staffname,staffemailaddress,staffmobilenumber from addstaff ", con);
            OpenConection();
            SqlDataAdapter da = new SqlDataAdapter(command);// this will query your database and return the result to your datatable

            da.Fill(dtReg);
            CloseConnection();
            return dtReg;

        }


        public void Mark_staff_Absent()
        {
            OpenConection();
            OpenConection();
            SqlCommand command = new SqlCommand("Select max(attendance_id) from attendance_details_of_staff ", con);
            int att_id = 0;
            object cMax = command.ExecuteScalar();
            if (cMax != DBNull.Value)
            {
                att_id = (int)cMax;
                att_id++;
            }
            else
            {
                att_id = 1;
            }

            string qry = "insert into attendance_details_of_staff values (" + att_id + ",@rln,GETDATE());";
            SqlCommand cmd1 = new SqlCommand(qry, con);
            cmd1.Parameters.AddWithValue("@rln", rono);
            cmd1.ExecuteNonQuery();

        }





        public DataTable Execute_student_absent_Queries()
        {

            //  SqlCommand command = new SqlCommand("Select * from S_Registration where name=@zip", conn);
            //   command.Parameters.AddWithValue("@zip", "india");
            OpenConection();
            DataTable dtReg = new DataTable();
            SqlCommand command = new SqlCommand("Select roll_no,date_of_absent,class from Attendance_Details ", con);
            OpenConection();
            SqlDataAdapter da = new SqlDataAdapter(command);// this will query your database and return the result to your datatable

            da.Fill(dtReg);
            CloseConnection();
            return dtReg;


        }

    }
}