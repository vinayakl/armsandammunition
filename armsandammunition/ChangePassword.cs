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
    public partial class ChangePassword : Form
    {
        SqlConnection con = null;
        public ChangePassword()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter old password");
                return;
            }
            if (txtNewPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter New password");
                return;
            }
            if (txtConfirmPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Confirm password");
                return;
            }
            if (!(txtNewPass.Text.Trim().Equals(txtConfirmPass.Text.Trim())))
            {
                MessageBox.Show("Password Missmatch");
                return;
            }
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand("select * from login", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["pass"].Equals(txtOldPass.Text))
                    {
                        flag = true;
                        break;
                    }
                }
                con.Close();
                if (flag)
                {
                    SqlCommand updateCmd = new SqlCommand("update login set pass='" + txtNewPass.Text + "'", con);
                    con.Open();
                    updateCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Changed Successfully");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
