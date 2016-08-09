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
    public partial class AssignArms : Form
    {
        SqlConnection con = null;
        public AssignArms()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void AssignArms_Load(object sender, EventArgs e)
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
            catch
            {

            }
            FillGrid();
        }

        private void cboEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Officer where OfficerName='"+cboEmployeeName.SelectedItem.ToString()+"'", con);
                con.Open();
                SqlDataReader dr = Selectcmd.ExecuteReader();
                while (dr.Read())
                {
                   txtEmpCode.Text=dr["ID"].ToString();
                   txtPost.Text = dr["Post"].ToString();
                }
                con.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Assign where EmployeeId='" + txtEmpCode.Text+ "' and ArmsId='"+txtAmmunitionCode.Text+"'", con);
                con.Open();
                SqlDataReader dr = Selectcmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = true;
                    break;
                }
                con.Close();
                dr.Close();
                if (flag)
                {
                    MessageBox.Show("Arms Already Assigned to the Officer");
                }
                else
                {
                    SqlCommand InsertCmd = new SqlCommand("INSERT into Assign (EmployeeId,ArmsId,EmployeeName,AmmunitionName,AssignDate)values('" + txtEmpCode.Text + "','" + txtAmmunitionCode.Text + "','" + cboEmployeeName.SelectedItem.ToString() + "','" + cboAmmName.SelectedItem.ToString() + "','" + DateTime.Now.ToShortDateString() + "')", con);
                    con.Open();
                    InsertCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Arms Assigned Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            FillGrid();
        }

        private void cboAmmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from ARMS where Name='" + cboAmmName.SelectedItem.ToString() + "'", con);
                con.Open();
                SqlDataReader dr = Selectcmd.ExecuteReader();
                while (dr.Read())
                {
                    txtAmmunitionCode.Text= dr["SerialNo"].ToString();
                    
                }
                con.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void FillGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Assign",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Assign");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
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
                    SqlCommand InsertCmd = new SqlCommand("delete from Assign where AssignId=" + ID, con);
                    con.Open();
                    InsertCmd.ExecuteNonQuery();

                    MessageBox.Show("Arms Deassigned Successfully");
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
