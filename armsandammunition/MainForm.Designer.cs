namespace armsandammunition
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBulletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignArmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignBulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignedGunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stdToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officerPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bullets = new System.Windows.Forms.ToolStripButton();
            this.Arms = new System.Windows.Forms.ToolStripButton();
            this.Officer = new System.Windows.Forms.ToolStripButton();
            this.History = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.Password = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBulletToolStripMenuItem,
            this.addGunToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.assignArmsToolStripMenuItem,
            this.assignBulletsToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // addBulletToolStripMenuItem
            // 
            this.addBulletToolStripMenuItem.Name = "addBulletToolStripMenuItem";
            this.addBulletToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addBulletToolStripMenuItem.Text = "Add Bullet";
            this.addBulletToolStripMenuItem.Click += new System.EventHandler(this.addBulletToolStripMenuItem_Click);
            // 
            // addGunToolStripMenuItem
            // 
            this.addGunToolStripMenuItem.Name = "addGunToolStripMenuItem";
            this.addGunToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addGunToolStripMenuItem.Text = "Add Arm";
            this.addGunToolStripMenuItem.Click += new System.EventHandler(this.addGunToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addUserToolStripMenuItem.Text = "Add Officer";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // assignArmsToolStripMenuItem
            // 
            this.assignArmsToolStripMenuItem.Name = "assignArmsToolStripMenuItem";
            this.assignArmsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.assignArmsToolStripMenuItem.Text = "Assign Arms";
            this.assignArmsToolStripMenuItem.Click += new System.EventHandler(this.assignArmsToolStripMenuItem_Click);
            // 
            // assignBulletsToolStripMenuItem
            // 
            this.assignBulletsToolStripMenuItem.Name = "assignBulletsToolStripMenuItem";
            this.assignBulletsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.assignBulletsToolStripMenuItem.Text = "Assign Bullets";
            this.assignBulletsToolStripMenuItem.Click += new System.EventHandler(this.assignBulletsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserToolStripMenuItem,
            this.bulletHistoryToolStripMenuItem,
            this.gunHistoryToolStripMenuItem,
            this.assigneToolStripMenuItem,
            this.assignedGunsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editUserToolStripMenuItem.Text = "Officer Post";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // bulletHistoryToolStripMenuItem
            // 
            this.bulletHistoryToolStripMenuItem.Name = "bulletHistoryToolStripMenuItem";
            this.bulletHistoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bulletHistoryToolStripMenuItem.Text = "Bullet History";
            this.bulletHistoryToolStripMenuItem.Click += new System.EventHandler(this.bulletHistoryToolStripMenuItem_Click);
            // 
            // gunHistoryToolStripMenuItem
            // 
            this.gunHistoryToolStripMenuItem.Name = "gunHistoryToolStripMenuItem";
            this.gunHistoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.gunHistoryToolStripMenuItem.Text = "Arms History";
            this.gunHistoryToolStripMenuItem.Click += new System.EventHandler(this.gunHistoryToolStripMenuItem_Click);
            // 
            // assigneToolStripMenuItem
            // 
            this.assigneToolStripMenuItem.Name = "assigneToolStripMenuItem";
            this.assigneToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.assigneToolStripMenuItem.Text = "Assigned Bullets";
            this.assigneToolStripMenuItem.Click += new System.EventHandler(this.assigneToolStripMenuItem_Click);
            // 
            // assignedGunsToolStripMenuItem
            // 
            this.assignedGunsToolStripMenuItem.Name = "assignedGunsToolStripMenuItem";
            this.assignedGunsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.assignedGunsToolStripMenuItem.Text = "Assigned Arms";
            this.assignedGunsToolStripMenuItem.Click += new System.EventHandler(this.assignedGunsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officerReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // officerReportToolStripMenuItem
            // 
            this.officerReportToolStripMenuItem.Name = "officerReportToolStripMenuItem";
            this.officerReportToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.officerReportToolStripMenuItem.Text = "Officer Report";
            this.officerReportToolStripMenuItem.Click += new System.EventHandler(this.officerReportToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stdToolbarToolStripMenuItem,
            this.officerPasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // stdToolbarToolStripMenuItem
            // 
            this.stdToolbarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem});
            this.stdToolbarToolStripMenuItem.Name = "stdToolbarToolStripMenuItem";
            this.stdToolbarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.stdToolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // officerPasswordToolStripMenuItem
            // 
            this.officerPasswordToolStripMenuItem.Name = "officerPasswordToolStripMenuItem";
            this.officerPasswordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.officerPasswordToolStripMenuItem.Text = "Change Password";
            this.officerPasswordToolStripMenuItem.Click += new System.EventHandler(this.officerPasswordToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSoftwareToolStripMenuItem,
            this.createdByToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSoftwareToolStripMenuItem
            // 
            this.aboutSoftwareToolStripMenuItem.Name = "aboutSoftwareToolStripMenuItem";
            this.aboutSoftwareToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutSoftwareToolStripMenuItem.Text = "About Software";
            this.aboutSoftwareToolStripMenuItem.Click += new System.EventHandler(this.aboutSoftwareToolStripMenuItem_Click);
            // 
            // createdByToolStripMenuItem
            // 
            this.createdByToolStripMenuItem.Name = "createdByToolStripMenuItem";
            this.createdByToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createdByToolStripMenuItem.Text = "Created By";
            this.createdByToolStripMenuItem.Click += new System.EventHandler(this.createdByToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Bullets
            // 
            this.Bullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bullets.Image = ((System.Drawing.Image)(resources.GetObject("Bullets.Image")));
            this.Bullets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bullets.Name = "Bullets";
            this.Bullets.Size = new System.Drawing.Size(32, 34);
            this.Bullets.Text = "toolStripButton2";
            this.Bullets.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Arms
            // 
            this.Arms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Arms.Image = ((System.Drawing.Image)(resources.GetObject("Arms.Image")));
            this.Arms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Arms.Name = "Arms";
            this.Arms.Size = new System.Drawing.Size(32, 34);
            this.Arms.Text = "toolStripButton3";
            this.Arms.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Officer
            // 
            this.Officer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Officer.Image = ((System.Drawing.Image)(resources.GetObject("Officer.Image")));
            this.Officer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Officer.Name = "Officer";
            this.Officer.Size = new System.Drawing.Size(32, 34);
            this.Officer.Text = "toolStripButton4";
            this.Officer.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // History
            // 
            this.History.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.History.Image = ((System.Drawing.Image)(resources.GetObject("History.Image")));
            this.History.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(32, 34);
            this.History.Text = "toolStripButton5";
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Reports
            // 
            this.Reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(32, 34);
            this.Reports.Text = "toolStripButton6";
            // 
            // Password
            // 
            this.Password.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Password.Image = ((System.Drawing.Image)(resources.GetObject("Password.Image")));
            this.Password.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(32, 34);
            this.Password.Text = "toolStripButton7";
            this.Password.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 34);
            this.Exit.Text = "toolStripButton9";
            this.Exit.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bullets,
            this.Arms,
            this.Officer,
            this.History,
            this.Reports,
            this.Password,
            this.Exit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 453);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::armsandammunition.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 477);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBulletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gunHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stdToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officerPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignArmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignedGunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignBulletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Bullets;
        private System.Windows.Forms.ToolStripButton Arms;
        private System.Windows.Forms.ToolStripButton Officer;
        private System.Windows.Forms.ToolStripButton History;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton Password;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}