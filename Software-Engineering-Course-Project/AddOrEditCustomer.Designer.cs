namespace Software_Engineering_Course_Project
{
    partial class AddOrEditCustomer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerEmailTxtBox = new System.Windows.Forms.TextBox();
            this.customerNameTxtBox = new System.Windows.Forms.TextBox();
            this.textVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerPlanComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Customer Email";
            // 
            // customerEmailTxtBox
            // 
            this.customerEmailTxtBox.Location = new System.Drawing.Point(166, 153);
            this.customerEmailTxtBox.Name = "customerEmailTxtBox";
            this.customerEmailTxtBox.Size = new System.Drawing.Size(158, 20);
            this.customerEmailTxtBox.TabIndex = 31;
            // 
            // customerNameTxtBox
            // 
            this.customerNameTxtBox.Location = new System.Drawing.Point(166, 106);
            this.customerNameTxtBox.Name = "customerNameTxtBox";
            this.customerNameTxtBox.Size = new System.Drawing.Size(158, 20);
            this.customerNameTxtBox.TabIndex = 30;
            // 
            // textVersionComboBox
            // 
            this.textVersionComboBox.FormattingEnabled = true;
            this.textVersionComboBox.Location = new System.Drawing.Point(166, 45);
            this.textVersionComboBox.Name = "textVersionComboBox";
            this.textVersionComboBox.Size = new System.Drawing.Size(121, 21);
            this.textVersionComboBox.TabIndex = 29;
            this.textVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.textVersionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer Plan";
            // 
            // customerPlanComboBox
            // 
            this.customerPlanComboBox.FormattingEnabled = true;
            this.customerPlanComboBox.Location = new System.Drawing.Point(166, 211);
            this.customerPlanComboBox.Name = "customerPlanComboBox";
            this.customerPlanComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerPlanComboBox.TabIndex = 37;
            // 
            // AddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerPlanComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerEmailTxtBox);
            this.Controls.Add(this.customerNameTxtBox);
            this.Controls.Add(this.textVersionComboBox);
            this.Name = "AddOrEditCustomer";
            this.Text = "AddOrEditCustomer";
            this.Load += new System.EventHandler(this.AddOrEditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerEmailTxtBox;
        private System.Windows.Forms.TextBox customerNameTxtBox;
        private System.Windows.Forms.ComboBox textVersionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerPlanComboBox;
    }
}