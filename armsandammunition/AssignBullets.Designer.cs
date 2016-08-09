namespace armsandammunition
{
    partial class AssignBullets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnob = new System.Windows.Forms.TextBox();
            this.cbobname = new System.Windows.Forms.ComboBox();
            this.lblbname = new System.Windows.Forms.Label();
            this.lblnob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.cboOfficerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnob);
            this.groupBox1.Controls.Add(this.cbobname);
            this.groupBox1.Controls.Add(this.lblbname);
            this.groupBox1.Controls.Add(this.lblnob);
            this.groupBox1.Location = new System.Drawing.Point(352, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Bullets";
            // 
            // txtnob
            // 
            this.txtnob.Location = new System.Drawing.Point(133, 71);
            this.txtnob.Name = "txtnob";
            this.txtnob.Size = new System.Drawing.Size(121, 20);
            this.txtnob.TabIndex = 5;
            // 
            // cbobname
            // 
            this.cbobname.FormattingEnabled = true;
            this.cbobname.Location = new System.Drawing.Point(133, 31);
            this.cbobname.Name = "cbobname";
            this.cbobname.Size = new System.Drawing.Size(121, 21);
            this.cbobname.TabIndex = 4;
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Location = new System.Drawing.Point(24, 39);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(70, 13);
            this.lblbname.TabIndex = 2;
            this.lblbname.Text = "Bullet Name :";
            // 
            // lblnob
            // 
            this.lblnob.AutoSize = true;
            this.lblnob.Location = new System.Drawing.Point(24, 74);
            this.lblnob.Name = "lblnob";
            this.lblnob.Size = new System.Drawing.Size(75, 13);
            this.lblnob.TabIndex = 3;
            this.lblnob.Text = "No Of Bullets :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Officer Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Deassign";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Officer Code";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(118, 67);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(157, 20);
            this.txtempid.TabIndex = 7;
            // 
            // cboOfficerName
            // 
            this.cboOfficerName.FormattingEnabled = true;
            this.cboOfficerName.Location = new System.Drawing.Point(118, 31);
            this.cboOfficerName.Name = "cboOfficerName";
            this.cboOfficerName.Size = new System.Drawing.Size(157, 21);
            this.cboOfficerName.TabIndex = 8;
            this.cboOfficerName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Post";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(118, 98);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(157, 20);
            this.txtPost.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPost);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboOfficerName);
            this.groupBox2.Controls.Add(this.txtempid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 135);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Officer Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // AssignBullets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AssignBullets";
            this.Text = "AssignBullets";
            this.Load += new System.EventHandler(this.AssignBullets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbobname;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.Label lblnob;
        private System.Windows.Forms.TextBox txtnob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.ComboBox cboOfficerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}