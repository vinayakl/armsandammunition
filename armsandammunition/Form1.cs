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
    public partial class frmloginform : Form
    {
        SqlConnection con = null;
        public frmloginform()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmloginform_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          bool exist=false;
            if (txtlogin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Login name");
                txtlogin.Focus();
                return;
            }
            if (txtpassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Password");
                txtpassword.Focus();
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("select * from login where uname='" + txtlogin.Text + "' and pass='" + txtpassword.Text + "'",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    exist=true;
                }
                if(exist)
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
