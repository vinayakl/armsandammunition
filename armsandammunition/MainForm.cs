using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace armsandammunition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Bullets ab = new Add_Bullets();
            ab.MdiParent = this;
            ab.Show();

        }

        private void addGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBullet ab = new AddBullet();//create a AddBullet Form Object
            ab.MdiParent = this; //set the Mdi Parent property of the AddBullet Form to the current form
            ab.Show(); //Show the form
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }

        private void officerPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOfficer ab = new AddOfficer();
            ab.MdiParent = this;
            ab.Show();
        }

        private void assignArmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignArms aa = new AssignArms();
            aa.MdiParent = this;
            aa.Show();
        }

        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Add_Bullets ab = new Add_Bullets();
            ab.MdiParent = this;
            ab.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AddBullet aa = new AddBullet();
            aa.MdiParent = this;
            aa.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AddOfficer ao = new AddOfficer();
            ao.MdiParent = this;
            ao.Show();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficerPost op = new OfficerPost();
            op.MdiParent = this;
            op.Show();
        }

        private void bulletHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulletHistory bh = new BulletHistory();
            bh.MdiParent = this;
            bh.Show();

        }

        private void gunHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunHistory  gh = new GunHistory();
            gh.MdiParent = this;
            gh.Show();
        }

        private void assignedGunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignedArms aa = new AssignedArms();
            aa.MdiParent = this;
            aa.Show();
        }

        private void assignBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignBullets ab = new AssignBullets();
            ab.MdiParent = this;
            ab.Show();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSoftware az=new AboutSoftware();
            az.MdiParent=this;
            az.Show();
        }

        private void assigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignedBullets ab = new AssignedBullets();
            ab.MdiParent = this;
            ab.Show();
        }

        private void officerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficerHistory oh = new OfficerHistory();
            oh.MdiParent = this;
            oh.Show();
        }

        private void createdByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatedBy cb = new CreatedBy();
            cb.MdiParent = this;
            cb.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ChangePassword cb = new ChangePassword();
            cb.MdiParent = this;
            cb.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void History_Click(object sender, EventArgs e)
        {
            GunHistory gh = new GunHistory();
            gh.MdiParent = this;
            gh.Show();
        }

        

        

        
        

        
    }
}
