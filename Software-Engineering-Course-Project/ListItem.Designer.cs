namespace Software_Engineering_Course_Project
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.sss = new System.Windows.Forms.Label();
            this.admin_label = new System.Windows.Forms.Label();
            this.cachedCrystalReport11 = new Software_Engineering_Course_Project.CachedCrystalReport1();
            this.ss = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nameLabel.Location = new System.Drawing.Point(250, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID :";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.idLabel.Location = new System.Drawing.Point(271, 52);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(363, 20);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(79, 17);
            this.email.TabIndex = 4;
            this.email.Text = "User Email :";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email_label.Location = new System.Drawing.Point(496, 20);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(39, 17);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // sss
            // 
            this.sss.AutoSize = true;
            this.sss.Location = new System.Drawing.Point(363, 61);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(71, 17);
            this.sss.TabIndex = 6;
            this.sss.Text = "Is Admin ?";
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.admin_label.Location = new System.Drawing.Point(490, 61);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(45, 17);
            this.admin_label.TabIndex = 7;
            this.admin_label.Text = "admin";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(157, 84);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(85, 17);
            this.ss.TabIndex = 8;
            this.ss.Text = "User Salary :";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salaryLabel.Location = new System.Drawing.Point(271, 84);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(45, 17);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 10);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Engineering_Course_Project.Properties.Resources.engz2_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 98);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.sss);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(801, 150);
            this.Load += new System.EventHandler(this.ListItem_Load);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label sss;
        private System.Windows.Forms.Label admin_label;
        private CachedCrystalReport1 cachedCrystalReport11;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
