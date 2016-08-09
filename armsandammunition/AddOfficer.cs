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
    public partial class AddOfficer : Form
    {
        int saveflag = 1;
        SqlConnection con = null;
        public AddOfficer()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
            fillgrid();
            disableControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillgrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Officer",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Officer");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void enableControls()
        {
            txtName.Enabled = true;
            txtAge.Enabled = true;
            cboPost.Enabled = true;
            txtPoliceStation.Enabled = true;
            dtpDateOfJoin.Enabled = true;
            dtpDOB.Enabled = true;
        }
        private void disableControls()
        {
            txtName.Enabled = false;
            txtAge.Enabled = true;
            cboPost.Enabled = true;
            txtPoliceStation.Enabled = true;
            dtpDateOfJoin.Enabled = true;
            dtpDOB.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            saveflag = 1;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            enableControls();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Name");
                return;
            }
            if (cboPost.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Post");
                return;
            }
            if (txtAge.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Age");
                return;
            }
            if (dtpDOB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter DOB");
                return;
            }
            if (dtpDateOfJoin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter DOJ");
                return;
            }
            if (txtPoliceStation.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Police Station");
                return;
            }
            bool flag = false;
            if (saveflag == 1)
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Officer", con);
               con.Open();
               SqlDataReader dr=Selectcmd.ExecuteReader();
               while(dr.Read())
               {
                   if (txtName.Text.Equals(dr["OfficerName"].ToString()))
                   {
                       flag = true;
                       break;
                   }
               }
               con.Close();
               if (flag)
               {
                   MessageBox.Show("Officer Already Exists");
               }
               else
               {
                   SqlCommand cmd = new SqlCommand("INSERT Into Officer (OfficerName,Post,Age,DOB,DOJ,PoliceStation)values('" + txtName.Text + "','" + cboPost.SelectedItem.ToString() + "','" + txtAge.Text + "','" + dtpDOB.Text + "','" + dtpDateOfJoin.Text + "','" + txtPoliceStation.Text + "')", con);
                   con.Open();
                   cmd.ExecuteNonQuery();
                   con.Close();
                   MessageBox.Show("Officer Added Successfully");
               }
            }
            else
            {

                SqlCommand cmd = new SqlCommand("UPDATE Officer set OfficerName='" + txtName.Text + "',Post='" + cboPost.SelectedItem.ToString() + "',Age='" + txtAge.Text + "',DOB='" + dtpDOB.Text + "',DOJ='" + dtpDateOfJoin.Text + "',PoliceStation='" + txtPoliceStation.Text + "' where ID="+label1.Text+"", con);
                con.Open();
                 cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Officer Updated Successfully");
            }
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            disableControls();
            fillgrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            saveflag = 2;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            enableControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        String ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        SqlCommand cmd = new SqlCommand("delete from Officer where ID=" + ID, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Officer Deleted Successfully");
                    }
                }
            }
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            disableControls();
            fillgrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        label1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        cboPost.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txtAge.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        dtpDOB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        dtpDateOfJoin.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        txtPoliceStation.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

                    }
                }
            }
        }
   }
}
