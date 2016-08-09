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
    public partial class Add_Bullets : Form
    {
        SqlConnection con = null;
        public Add_Bullets()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            String bname, btype, bbrand, bprice, bweight, bcase, bvelocity, bpowder, bamount, bjacket;
            bool flag = false;
            bname = txtBulletName.Text;
            btype = cboBulletType.Text;
            bbrand = txtBulletBrand.Text;
            bprice = txtBulletPrice.Text;
            bweight = txtBulletWeight.Text;
            bcase = txtBulletCase.Text;
            bvelocity = txtBulletVelocity.Text;
            bpowder = txtBulletPowder.Text;
            bamount = txtBulletAmount.Text;
            bjacket = txtBulletJacket.Text;

            if (txtBulletName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Name");
                txtBulletName.Focus();
                return;
            }
            if (cboBulletType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Type");
                cboBulletType.Focus();
                return;
            }
            if (txtBulletBrand.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Brand");
                txtBulletBrand.Focus();
                return;
            }
            if (txtBulletPrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Price");
                txtBulletPrice.Focus();
                return;
            }
            if (txtBulletWeight.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Weight");
                txtBulletWeight.Focus();
                return;
            }
            if (txtBulletCase.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Case");
                txtBulletCase.Focus();
                return;
            }
            if (txtBulletVelocity.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Velocity");
                txtBulletVelocity.Focus();
                return;
            }
            if (txtBulletPowder.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Powder");
                txtBulletPowder.Focus();
                return;
            }
            if (txtBulletAmount.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Amount");
                txtBulletAmount.Focus();
                return;
            }
            if (txtBulletJacket.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Bullet Jacket");
                txtBulletJacket.Focus();
                return;
            }
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Bullet", con);
               con.Open();
               SqlDataReader dr=Selectcmd.ExecuteReader();
               while(dr.Read())
               {
                   if (txtBulletName.Text.Equals(dr["BulletName"].ToString()))
                   {
                       flag = true;
                       break;
                   }
               }
               con.Close();
               if (flag)
               {
                   MessageBox.Show("Bullet Already Exists");
               }
               else
               {
                   SqlCommand cmd = new SqlCommand("INSERT Into Bullet (BulletName,Type,Brand,Price,Weight,BulletCase,Velocity,Powder,Amount,Jacket)values('" + txtBulletName.Text + "','" + cboBulletType.SelectedItem.ToString() + "','" + txtBulletBrand.Text + "','" + txtBulletPrice.Text + "','" + txtBulletWeight.Text + "','" + txtBulletCase.Text+"','"+txtBulletVelocity.Text+"','"+txtBulletPowder.Text+"','"+txtBulletAmount.Text+"','"+txtBulletJacket.Text+ "')", con);
                   con.Open();
                   cmd.ExecuteNonQuery();
                   con.Close();
                   MessageBox.Show("Bullet Added Successfully");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        
        
    }
}
