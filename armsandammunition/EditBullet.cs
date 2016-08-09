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
    public partial class EditBullet : Form
    {
        SqlConnection con = null;

        public EditBullet()
        {
            InitializeComponent();
            con = new SqlConnection("server=localhost;uid=sa;pwd=;database=armsdb");
        }

        private void EditBullet_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Bullet",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bullet");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
