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
    public partial class OfficerPost : Form
    {
        SqlConnection con = null;
        public OfficerPost()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            FillGrid();
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Officer where ID='" + txtID.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtName.Text = dr["OfficerName"].ToString();
                    txtPost.Text = dr["Post"].ToString();
                    txtStation.Text = dr["PoliceStation"].ToString();
                    txtAge.Text = dr["Age"].ToString();
                    txtDOB.Text = dr["DOB"].ToString();
                    txtDOJ.Text = dr["DOJ"].ToString();
                }
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
        private void FillGrid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Officer", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Officer");
            dataGridView1.DataSource = ds.Tables[0];
            //btnedit.Show();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        txtPost.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txtAge.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        txtDOB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        txtDOJ.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        txtStation.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        
                    }
                }
            }
        }

        private void txtpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OfficerPost_Load(object sender, EventArgs e)
        {

        }
    }
}
