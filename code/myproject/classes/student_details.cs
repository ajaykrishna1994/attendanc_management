using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace myproject.classes
{
    public class student_details
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

        internal DataTable ExecuteSelectQueries()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQueries(string Query_)
        {
            // Whenever you want to execute a query, like an insert, update or delete
            //query then simply call this function 
            //using the object of a class and pass your query to the function
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        private string leave_student_name;
        private string leave_student_class;
        private string leave_start_date;
        private string leave_end_date;

        public string Leave_student_name
        {
            get
            {
                return leave_student_name;
            }

            set
            {
                leave_student_name = value;
            }
        }

        public string Leave_student_class
        {
            get
            {
                return leave_student_class;
            }

            set
            {
                leave_student_class = value;
            }
        }

        public string Leave_start_date
        {
            get
            {
                return leave_start_date;
            }

            set
            {
                leave_start_date = value;
            }
        }

        public string Leave_end_date
        {
            get
            {
                return leave_end_date;
            }

            set
            {
                leave_end_date = value;
            }

       }

        public void Inseret_student_details()
        {
            OpenConection();
            string qrystd = "insert into student_applying_leave values ('" + leave_student_name + "','" + leave_student_class + "','" + leave_start_date + "','" + leave_end_date + "');";
            ExecuteQueries(qrystd);
        }

        public DataTable student_can_view_attendance_query()
        {

            //  SqlCommand command = new SqlCommand("Select * from S_Registration where name=@zip", conn);
            //   command.Parameters.AddWithValue("@zip", "india");
            OpenConection();
            DataTable dtReg = new DataTable();
            SqlCommand command = new SqlCommand("select studentregistration.studentname,Attendance_Details.date_of_absent from  studentregistration inner join Attendance_Details on studentregistration.roll_no=Attendance_Details.roll_no ", con);
            OpenConection();
            SqlDataAdapter da = new SqlDataAdapter(command);// this will query your database and return the result to your datatable

            da.Fill(dtReg);
            CloseConnection();
            return dtReg;


        }





    }
}