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
    public partial class AddBullet : Form
    {
        SqlConnection con = null;
        public AddBullet()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sno,name,mno,type,capacity,bno,pdate,pprice,mfgr,mfgrctry,mfgingdate,cartridge,bl;
            sno = txtSerialNo.Text;
            name = txtName.Text;
            mno=txtModelNo.Text;
            type=cboType.Text;
            capacity=txtCapacity.Text;
            bno=txtBatchNo.Text;
            pdate=dtpPurchaseDate.Text;
            pprice=txtPurchasePrice.Text;
            mfgr=txtManufacturer.Text;
            mfgrctry=txtManufacturerCountry.Text;
            mfgingdate=dtpManufacturingDate.Text;
            cartridge=cboCartridge.Text;
            bl = txtBarrelLength.Text;



            
            if (txtSerialNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Serial No");
                txtSerialNo.Focus();
                return;
            }
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Name");
                txtName.Focus();
                return;
            }
            if (txtModelNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Model No");
                txtModelNo.Focus();
                return;
            }
            if (cboType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Type");
                cboType.Focus();
                return;
            }
            if (txtCapacity.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Capacity");
                txtCapacity.Focus();
                return;
            }
            if (txtBatchNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("EnterBatch No");
                txtBatchNo.Focus();
                return;
            }
            if (dtpPurchaseDate.Text.Trim().Equals(""))
            {
                MessageBox.Show("EnterPurchase Date");
                dtpPurchaseDate.Focus();
                return;
            }
            if (txtPurchasePrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Purchase Price");
                txtPurchasePrice.Focus();
                return;
            }
            if (txtManufacturer.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Manufacturer");
                txtManufacturer.Focus();
                return;
            }
            if (txtManufacturerCountry.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Manufacturer Conutry");
                txtManufacturerCountry.Focus();
                return;
            }
            if (dtpManufacturingDate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Manufacturer Date");
                dtpManufacturingDate.Focus();
                return;
            }
            if (cboCartridge.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Cartridge");
                cboCartridge.Focus();
                return;
            }
            if (txtBarrelLength.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Barrel Length");
                txtBarrelLength.Focus();
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ARMS(SerialNo,Name,ModelNo,Type,Capacity,BatchNo,PurchaseDate,PurchasePrice,Manufacturer,MfgCountry,MfgDate,Cartridge,BarrelLength) values ('" + sno + "','" + name + "','" + mno + "','" + type + "','" + capacity + "','" + bno + "','" + pdate + "','" + pprice + "','" + mfgr + "','" + mfgrctry + "','" + mfgingdate + "','" + cartridge + "','" + bl + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Arms Marked Successfully");

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

        private void AddBullet_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Selectcmd = new SqlCommand("Select * from Bullet", con);
                con.Open();
                SqlDataReader dr = Selectcmd.ExecuteReader();
                while (dr.Read())
                {
                   cboCartridge.Items.Add(dr["BulletName"].ToString());
                }
                con.Close();
                dr.Close();
              
            }
            catch
            {

            }
        }

        
    }
}
