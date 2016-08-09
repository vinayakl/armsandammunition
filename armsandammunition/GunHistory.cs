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
    public partial class GunHistory : Form
    {
        SqlConnection con = null;
        public GunHistory()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            FillGrid();
        }

        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ARMS where SerialNo='" + txtSerialNo.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtName.Text= dr["SerialNo"].ToString();
                    txtModelNo.Text = dr["Name"].ToString();
                    txtType.Text= dr["ModelNo"].ToString();
                    txtCapacity.Text = dr["Type"].ToString();
                    txtBatchNo.Text = dr["Capacity"].ToString();
                    txtPurchaseDate.Text= dr["BatchNo"].ToString();
                    txtPurchasePrice.Text = dr["PurchaseDate"].ToString();
                    txtManufacturer.Text = dr["PurchasePrice"].ToString();
                    txtManufacturerCountry.Text = dr["Manufacturer"].ToString();
                    txtManufacturingDate.Text = dr["MfgCountry"].ToString();
                    txtCartridge.Text = dr["MfgDate"].ToString();
                    txtBarrelLength.Text = dr["BarrelLength"].ToString();
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

            SqlDataAdapter da = new SqlDataAdapter("Select * from ARMS", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ARMS");
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
                        txtSerialNo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        txtModelNo.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txtType.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        txtCapacity.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
                        txtBatchNo.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        txtPurchaseDate.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        txtPurchasePrice.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
                        txtManufacturer.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        txtManufacturerCountry.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                        txtManufacturingDate.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                        txtCartridge.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                        txtBarrelLength.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
