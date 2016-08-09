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
    public partial class BulletHistory : Form
    {
        SqlConnection con = null;
        public BulletHistory()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            FillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBulletName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Bullet where BulletName='" + txtBulletName.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtType.Text = dr["Type"].ToString();
                    txtBulletBrand.Text = dr["Brand"].ToString();
                    txtBulletPrice.Text = dr["Price"].ToString();
                    txtBulletWeight.Text = dr["Weight"].ToString();
                    txtBulletCase.Text = dr["BulletCase"].ToString();
                    txtBulletVelocity.Text= dr["Velocity"].ToString();
                    txtBulletPowder.Text = dr["Powder"].ToString();
                    txtBulletAmount.Text = dr["Amount"].ToString();
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

            SqlDataAdapter da = new SqlDataAdapter("Select * from Bullet", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bullet");
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
                      txtBulletName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                       txtType.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                      txtBulletBrand.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                      txtBulletPrice.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                      txtBulletWeight.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                      txtBulletCase.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                     txtBulletVelocity.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                     txtBulletPowder.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    txtBulletAmount.Text=dataGridView1.Rows[i].Cells[8].Value.ToString();
                    }
                }
            }
        }
    }
}
