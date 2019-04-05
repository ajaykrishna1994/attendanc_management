using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace myproject.classes
{
    public class student
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

        internal void InsertStudentt()
        {
            throw new NotImplementedException();
        }

        private string name;
        private string stream;
        private string username;
        private string password;
        private string staffname;
        private string staffemailaddress;
        private string staffmobilenumber;
        private string staffusername;
        private string staffpassword;
        private string studentname;
        private string studentpassword;
        private string studentusername;
        private string studentemail;
        private string studentmobilenumber;
        private string logusername;
        private string logpassword;
        private string section;
        private string staffusertype;
        private string studentrollno;
        private int rno;
        private string absdate;
        private string batch;
        private string staff_id;





        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Stream
        {
            get
            {
                return stream;
            }

            set
            {
                stream = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Staffname
        {
            get
            {
                return staffname;
            }

            set
            {
                staffname = value;
            }
        }

        public string Staffemailaddress
        {
            get
            {
                return staffemailaddress;
            }

            set
            {
                staffemailaddress = value;
            }
        }

        public string Staffmobilenumber
        {
            get
            {
                return staffmobilenumber;
            }

            set
            {
                staffmobilenumber = value;
            }
        }

        public string Staffusername
        {
            get
            {
                return staffusername;
            }

            set
            {
                staffusername = value;
            }
        }

        public string Staffpassword
        {
            get
            {
                return staffpassword;
            }

            set
            {
                staffpassword = value;
            }
        }

        public string Emailaddress { get; internal set; }

        public string Studentname
        {
            get
            {
                return studentname;
            }

            set
            {
                studentname = value;
            }
        }

        public string Studentpassword
        {
            get
            {
                return studentpassword;
            }

            set
            {
                studentpassword = value;
            }
        }

        public string Studentusername
        {
            get
            {
                return studentusername;
            }

            set
            {
                studentusername = value;
            }
        }

        public string Studentemail
        {
            get
            {
                return studentemail;
            }

            set
            {
                studentemail = value;
            }
        }

        public string Studentmobilenumber
        {
            get
            {
                return studentmobilenumber;
            }

            set
            {
                studentmobilenumber = value;
            }
        }

        public string Logusername
        {
            get
            {
                return logusername;
            }

            set
            {
                logusername = value;
            }
        }

        public string Logpassword
        {
            get
            {
                return logpassword;
            }

            set
            {
                logpassword = value;
            }
        }

        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public string Staffusertype
        {
            get
            {
                return staffusertype;
            }

            set
            {
                staffusertype = value;
            }
        }

        public string Studentrollno
        {
            get
            {
                return studentrollno;
            }

            set
            {
                studentrollno = value;
            }
        }

        public int Rno
        {
            get
            {
                return rno;
            }

            set
            {
                rno = value;
            }
        }

        public string Absdate
        {
            get
            {
                return absdate;
            }

            set
            {
                absdate = value;
            }
        }

        public string Batch
        {
            get
            {
                return batch;
            }

            set
            {
                batch = value;
            }
        }

        public string Staff_id
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

        public void InsertStudent()
        {
            OpenConection();
            string qry = "insert into registrationtable values ('" + name + "','" + stream + "','" + username + "','" + password + "');";
            ExecuteQueries(qry);
        }


        public void Insertstaff()
        {
            OpenConection();
            string qry1 = "insert into addstaff values ('" + staffname + "','" + Staff_id + "','" + staffemailaddress + "','" + staffmobilenumber + "','" + staffusername + "','" + staffpassword + "');";
            ExecuteQueries(qry1);
        }

        public void Insertstdn()
        {
            OpenConection();
            string qry2 = "insert into studentregistration values ('" + studentrollno + "','" + studentname + "','" + studentemail + "','" + studentmobilenumber + "','" + studentusername + "','" + studentpassword + "','" + section + "');";
            ExecuteQueries(qry2);
        }









        public int CheckLogin()
        {
            OpenConection();
            DataTable dtReg = new DataTable();
            SqlCommand command = new SqlCommand("Select count(*) from studentregistration where usertype=@secton and username=@uname and password=@pwd ", con);
            command.Parameters.AddWithValue("@uname", username);
            command.Parameters.AddWithValue("@pwd", password);
            command.Parameters.AddWithValue("@secton", section);
            object cMax = command.ExecuteScalar();


            CloseConnection();
            if (cMax != DBNull.Value)
            {
                if ((int)cMax == 1)
                    return 1;
                else
                    return 0;
            }
            else
                return 0;

        }











        public void MarkAbsent()
        {
            OpenConection();
            OpenConection();
            SqlCommand command = new SqlCommand("Select max(attendance_id) from Attendance_Details ", con);
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

            string qry = "insert into Attendance_Details values (" + att_id + ",@rno,GETDATE(),'5');";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@rno", rno);
            cmd.ExecuteNonQuery();

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
