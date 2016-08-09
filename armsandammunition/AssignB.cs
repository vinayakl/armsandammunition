using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace armsandammunition
{
    public partial class AssignB : Form
    {
        SqlConnection con = null;
        public AssignB()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Officer", con);
                con.Open();
                SqlDataReader dr = Selectcmd.ExecuteReader();
                while (dr.Read())
                {
                    cboEmployeeName.Items.Add(dr["OfficerName"].ToString());
                }
                con.Close();
                dr.Close();
                SqlCommand Selectcmd1 = new SqlCommand("Select * from ARMS", con);
                con.Open();
                SqlDataReader dr1 = Selectcmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cboAmmName.Items.Add(dr1["Name"].ToString());

                }
                con.Close();
                dr1.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());

            }
        }
    }
}
