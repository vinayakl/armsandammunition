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
    public partial class AssignedArms : Form
    {
        SqlConnection con = null;
        public AssignedArms()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmmunitionCode.Text.Trim().Equals(""))
                {
                    MessageBox.Show("First Enter Ammunition Code");
                    return;
                }
                SqlDataAdapter da = new SqlDataAdapter("Select * from Assign where ArmsId like '" + txtAmmunitionCode.Text.Trim() + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Assign");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }

        }

        private void txtAmmunitionCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
