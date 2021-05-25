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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditCustomer));
            this.customerEmailTxtBox = new System.Windows.Forms.TextBox();
            this.customerNameTxtBox = new System.Windows.Forms.TextBox();
            this.textVersionComboBox = new System.Windows.Forms.ComboBox();
            this.customerPlanComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerEmailTxtBox
            // 
            this.customerEmailTxtBox.Location = new System.Drawing.Point(277, 172);
            this.customerEmailTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerEmailTxtBox.Name = "customerEmailTxtBox";
            this.customerEmailTxtBox.Size = new System.Drawing.Size(200, 22);
            this.customerEmailTxtBox.TabIndex = 31;
            // 
            // customerNameTxtBox
            // 
            this.customerNameTxtBox.Location = new System.Drawing.Point(268, 106);
            this.customerNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerNameTxtBox.Name = "customerNameTxtBox";
            this.customerNameTxtBox.Size = new System.Drawing.Size(209, 22);
            this.customerNameTxtBox.TabIndex = 30;
            // 
            // textVersionComboBox
            // 
            this.textVersionComboBox.FormattingEnabled = true;
            this.textVersionComboBox.Location = new System.Drawing.Point(249, 37);
            this.textVersionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textVersionComboBox.Name = "textVersionComboBox";
            this.textVersionComboBox.Size = new System.Drawing.Size(228, 24);
            this.textVersionComboBox.TabIndex = 29;
            this.textVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.textVersionComboBox_SelectedIndexChanged);
            // 
            // customerPlanComboBox
            // 
            this.customerPlanComboBox.FormattingEnabled = true;
            this.customerPlanComboBox.Location = new System.Drawing.Point(267, 241);
            this.customerPlanComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerPlanComboBox.Name = "customerPlanComboBox";
            this.customerPlanComboBox.Size = new System.Drawing.Size(211, 24);
            this.customerPlanComboBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 38);
            this.label3.TabIndex = 40;
            this.label3.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(44, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 38);
            this.label5.TabIndex = 41;
            this.label5.Text = "Customer Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(51, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 38);
            this.label4.TabIndex = 42;
            this.label4.Text = "Customer Plan:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(356, 443);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 47);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.Location = new System.Drawing.Point(120, 443);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 47);
            this.deleteBtn.TabIndex = 44;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 503);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerPlanComboBox);
            this.Controls.Add(this.customerEmailTxtBox);
            this.Controls.Add(this.customerNameTxtBox);
            this.Controls.Add(this.textVersionComboBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrEditCustomer";
            this.Text = "AddOrEditCustomer";
            this.Load += new System.EventHandler(this.AddOrEditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerEmailTxtBox;
        private System.Windows.Forms.TextBox customerNameTxtBox;
        private System.Windows.Forms.ComboBox textVersionComboBox;
        private System.Windows.Forms.ComboBox customerPlanComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button deleteBtn;
    }
}