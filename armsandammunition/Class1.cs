using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace armsandammunition
{
    class MyConn
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        //SqlDataAdapter da = null;
        //default constructor
        public MyConn()
        {
            //set up a connection with parameter server,uid,pwd,database
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsandammunition");
        }
        //funvction to execute a select query without any condition
        public SqlDataReader SelectQuery(String tablename)
        {
            SqlDataReader dr=null;
            //create a sqlreader object to hold the result of the select query
            cmd=new SqlCommand("select * from"+tablename,con);
            //give the select query to the command object
            con.Open();//open the connection
            dr=cmd.ExecuteReader();
            //execute the query & store the result in datareader object
            con.Close();//close the connection
            return dr;//return the datareader object to calling function
        }
    
    }
}
