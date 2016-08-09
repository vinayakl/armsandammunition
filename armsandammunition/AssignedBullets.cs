using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace armsandammunition
{
    public partial class AssignedBullets : Form
    {
        SqlConnection con = null;
        public AssignedBullets()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            FillGrid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (dtpfrom.Text.Equals(""))
            {
                MessageBox.Show("First Enter 'From Date' Field");
                return;
            }
            if (dtpto.Text.Equals(""))
            {
                MessageBox.Show("First Enter 'To Date' Field");
                return;
            }
            SqlDataAdapter da = new SqlDataAdapter("Select * from AssignBullets where dateassigned between '" + dtpfrom.Text + "' and '"+dtpto.Text+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "AssignBullets");
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        private void FillGrid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from AssignBullets", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "AssignBullets");
            dataGridView1.DataSource = ds.Tables[0];
            //btnedit.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        txtasignedid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txtname.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txtnob.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO BulletRecord(AssignId,Record,RecordDate) values ('" + txtasignedid.Text + "','" + txtrecord.Text + "','"+DateTime.Now.ToShortDateString()+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            txtasignedid.Text = "";
            txtname.Text = "";
            txtnob.Text = "";
            txtrecord.Text = "";

        }

    }
}
