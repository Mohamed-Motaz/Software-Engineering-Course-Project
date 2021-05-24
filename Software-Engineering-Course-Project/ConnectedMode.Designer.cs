namespace Software_Engineering_Course_Project
{
    partial class ConnectedMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addOrEditUserBtn = new System.Windows.Forms.Button();
            this.viewAllUsersBtn = new System.Windows.Forms.Button();
            this.viewAllCustomersBtn = new System.Windows.Forms.Button();
            this.addOrEditCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the connected mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stored Procedure Type";
            // 
            // addOrEditUserBtn
            // 
            this.addOrEditUserBtn.Location = new System.Drawing.Point(72, 114);
            this.addOrEditUserBtn.Name = "addOrEditUserBtn";
            this.addOrEditUserBtn.Size = new System.Drawing.Size(96, 23);
            this.addOrEditUserBtn.TabIndex = 17;
            this.addOrEditUserBtn.Text = "Add Or Edit User";
            this.addOrEditUserBtn.UseVisualStyleBackColor = true;
            this.addOrEditUserBtn.Click += new System.EventHandler(this.addOrEditUserBtn_Click);
            // 
            // viewAllUsersBtn
            // 
            this.viewAllUsersBtn.Location = new System.Drawing.Point(72, 160);
            this.viewAllUsersBtn.Name = "viewAllUsersBtn";
            this.viewAllUsersBtn.Size = new System.Drawing.Size(96, 23);
            this.viewAllUsersBtn.TabIndex = 18;
            this.viewAllUsersBtn.Text = "View All Users";
            this.viewAllUsersBtn.UseVisualStyleBackColor = true;
            // 
            // viewAllCustomersBtn
            // 
            this.viewAllCustomersBtn.Location = new System.Drawing.Point(236, 160);
            this.viewAllCustomersBtn.Name = "viewAllCustomersBtn";
            this.viewAllCustomersBtn.Size = new System.Drawing.Size(114, 23);
            this.viewAllCustomersBtn.TabIndex = 20;
            this.viewAllCustomersBtn.Text = "View All Customers";
            this.viewAllCustomersBtn.UseVisualStyleBackColor = true;
            // 
            // addOrEditCustomerBtn
            // 
            this.addOrEditCustomerBtn.Location = new System.Drawing.Point(236, 114);
            this.addOrEditCustomerBtn.Name = "addOrEditCustomerBtn";
            this.addOrEditCustomerBtn.Size = new System.Drawing.Size(133, 23);
            this.addOrEditCustomerBtn.TabIndex = 19;
            this.addOrEditCustomerBtn.Text = "Add Or Edit Customer";
            this.addOrEditCustomerBtn.UseVisualStyleBackColor = true;
            this.addOrEditCustomerBtn.Click += new System.EventHandler(this.addOrEditCustomerBtn_Click);
            // 
            // ConnectedMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 367);
            this.Controls.Add(this.viewAllCustomersBtn);
            this.Controls.Add(this.addOrEditCustomerBtn);
            this.Controls.Add(this.viewAllUsersBtn);
            this.Controls.Add(this.addOrEditUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConnectedMode";
            this.Text = "ConnectedMode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectedMode_FormClosing);
            this.Load += new System.EventHandler(this.ConnectedMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addOrEditUserBtn;
        private System.Windows.Forms.Button viewAllUsersBtn;
        private System.Windows.Forms.Button viewAllCustomersBtn;
        private System.Windows.Forms.Button addOrEditCustomerBtn;
    }
}