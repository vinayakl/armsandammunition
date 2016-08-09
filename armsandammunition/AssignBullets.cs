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
    public partial class AssignBullets : Form
    {
        SqlConnection con = null;
        public AssignBullets()
        {
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignBullets_Load(object sender, EventArgs e)
        {
            SqlCommand myCmd = new SqlCommand("select BulletName from Bullet", con);
            con.Open();
            SqlDataReader dr = myCmd.ExecuteReader();
            while (dr.Read())
            {
                cbobname.Items.Add(dr["BulletName"].ToString());
            }
            con.Close();
            dr.Close();

            SqlCommand myCmd1 = new SqlCommand("select OfficerName from Officer", con);
            con.Open();
            SqlDataReader dr1 = myCmd1.ExecuteReader();
            while (dr1.Read())
            {
                cboOfficerName.Items.Add(dr1["OfficerName"].ToString());
            }
            con.Close();
            dr1.Close();
            FillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                string dateassigned = DateTime.Now.ToShortDateString();
                
                    string insertQuery = "insert into AssignBullets(empID,BulletName,noofbullets,dateassigned)values ('" + txtempid.Text + "','" + cbobname.Text + "','" + txtnob.Text + "','" + dateassigned + "')";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    con.Open();

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Bullets Assigned to Officer "+cboOfficerName.SelectedItem.ToString());

                    con.Close();

                    FillGrid();
            }
            
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Officer where OfficerName='"+cboOfficerName.SelectedItem.ToString()+"'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtempid.Text = dr["ID"].ToString();
                txtPost.Text = dr["Post"].ToString();
               
            }
            con.Close();
            dr.Close();
        }

        public void FillGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from AssignBullets", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "AssignBullets");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you Sure You want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                String ID = "";
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
                try
                {
                    SqlCommand InsertCmd = new SqlCommand("delete from AssignBullets where AssignId=" + ID, con);
                    con.Open();
                    InsertCmd.ExecuteNonQuery();

                    MessageBox.Show("Bullets Deassigned Successfully");
                    FillGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
